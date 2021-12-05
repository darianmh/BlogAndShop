using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductGroupService : MainService<ProductGroup>, IProductGroupService
    {
        #region Fields

        private readonly IProductService _productService;
        private readonly IBrandService _brandService;

        #endregion
        #region Methods

        public async Task<List<LinkGroupHeaderViewModel>> GetHeaderModel()
        {
            var allActives = await GetAllAsync();
            var model = GetHeaderModel(allActives);
            return model;
        }

        public async Task<List<ProductGroupModel>> GetHeaderNastedModel()
        {
            var allParents = await Queryable.Where(x => x.ParentId == null).ToListAsync();
            //var model = GetHeaderModel(allActives);
            var model = await GetHeader2Model(allParents);
            return model;
        }

        public async Task<ProductCategoryViewModel> GetGroupsModel(int? categoryId)
        {
            var groups = await GetSubGroups(categoryId);
            var current = await GetCurrentGroup(categoryId);
            return new ProductCategoryViewModel() { CurrentGroup = current, SubCategories = groups };
        }

        public async Task<ProductListViewModel> GetProductModel(int? categoryId, int? brandId, int page, int count)
        {
            var currentGroup = await GetCurrentGroup(categoryId);
            var products = await _productService.GetProductByGroup(categoryId, brandId, count, page, this);
            var brand = brandId == null ? null : await _brandService.GetByIdAsync((int)brandId);
            var result = new ProductListViewModel()
            {
                CurrentGroup = currentGroup,
                Products = products.List.Select(x => _productService.GetProductMiniModel(x)).ToList(),
                ListPaginationModel = new ListPaginationModel(products.TotalCount > page * count, hasPre: page > 1, page: page, count: products.List.Count, pagesCount: ((products.TotalCount - 1) / count) + 1),
                Brand = brand?.ToModel()
            };
            result.Keywords = GetKeywords(result.CurrentGroup, result.Products);
            result.HeaderText = GetHeaderGroupName(result);
            return result;
        }


        public async Task<List<ProductMiniModel>> GetSuggestedProduct(int productId, int groupId, int count = 4)
        {
            var productsWithGroup = await _productService.GetProductByGroup(groupId, brandId: null, count: count, page: 1, this);
            var result = CreateSuggestModel(productsWithGroup.List, productId);
            if (result.Count >= count)
                return result;
            var suggestedGroups = new List<int?>();
            while (result.Count < count)
            {
                var suggestedGroup = await GetSuggestedGroup(groupId, suggestedGroups);
                if (suggestedGroup != null)
                    suggestedGroups.Add(suggestedGroup);
                var temp = await GetGroupProducts(productId, count, suggestedGroup);
                result.AddRange(temp);
            }
            if (result.Count > 4) result = result.Take(4).ToList();
            return result;
        }


        public async Task<ProductGroupModel> GetByIdInModel(int groupId)
        {
            var group = await GetByIdAsync(groupId);
            return group.ToModel();
        }

        public async Task<List<ProductGroup>> GetByParentId(int productGroupId)
        {
            return await Queryable.Where(x => x.ParentId == productGroupId).ToListAsync();
        }

        public async Task<List<int>> GetChildrenGroupsId(int categoryId)
        {
            var group = await Queryable.Include(x => x.ProductGroups).FirstOrDefaultAsync(x => x.Id == categoryId);
            var list = new List<int>();
            if (group.ProductGroups != null)
            {
                list = group.ProductGroups.Select(x => x.Id).ToList();
                var tempList = new List<int>();
                foreach (var id in list)
                {
                    var temp = await GetChildrenGroupsId(id);
                    tempList.AddRange(temp);
                }

                list.AddRange(tempList);
            }

            list.Add(categoryId);
            return list.GroupBy(x => x).Select(x => x.First()).ToList();
        }

        #endregion
        #region Utilities

        /// <summary>
        /// بازگرداندن نام سربرگ محصولات
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private string GetHeaderGroupName(ProductListViewModel result)
        {
            var text = result.CurrentGroup?.Title;
            if (!string.IsNullOrEmpty(text)) text = text + " - ";
            text = text + result.Brand?.Name;
            return text ?? "همه محصولات";
        }


        /// <summary>
        /// تولید کلمات کلیدی با استفاده از ترکیب کلمات گروه و محصولات
        /// </summary>
        /// <returns></returns>
        private string GetKeywords(ProductGroupModel currentGroup, List<ProductMiniModel> products)
        {
            var allKeywords = currentGroup?.Keywords + "," + string.Join(',', products.Select(x => x.Keywords));
            var keywordsList = allKeywords.Split(',').GroupBy(x => x).Select(x => x).ToList();
            return string.Join(",", keywordsList);
        }
        private async Task<IEnumerable<ProductMiniModel>> GetGroupProducts(int productId, int count, int? suggestedGroup)
        {
            var productsWithGroup = await _productService.GetProductByGroup(suggestedGroup, brandId: null, count: count, page: 1, this);
            return CreateSuggestModel(productsWithGroup.List, productId);
        }


        /// <summary>
        /// دریافت یک پروه مشابه گروه داده شده
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="suggestedGroups"></param>
        /// <returns></returns>
        private async Task<int?> GetSuggestedGroup(int groupId, List<int?> suggestedGroups)
        {
            var group = await GetByIdAsync(groupId);
            if (group.ParentId != null && !suggestedGroups.Contains(group.ParentId))
                return group.ParentId.Value;
            //return GetRandomId();
            //todo set random
            return null;
        }

        private int GetRandomId()
        {
            var ids = Queryable.Select(x => x.Id).ToList();
            var max = ids.Count();
            var r = new Random();
            var num = r.Next(max - 1);
            return ids[num];
        }
        /// <summary>
        /// تبدیل محصولات به مدل به جز آن محصول داده شده
        /// </summary>
        /// <param name="list"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        private List<ProductMiniModel> CreateSuggestModel(List<Data.Data.Product.Product> list, in int productId)
        {
            var result = new List<ProductMiniModel>();
            foreach (var product in list)
            {
                if (product.Id == productId) continue;
                var model = _productService.GetProductMiniModel(product);
                result.Add(model);
            }

            return result;
        }


        /// <summary>
        /// دریافت گروه فعلی اگر موجود بود
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        private async Task<ProductGroupModel> GetCurrentGroup(int? categoryId)
        {
            if (categoryId == null) return null;
            var group = await GetByIdAsync((int)categoryId);
            return @group?.ToModel();
        }

        /// <summary>
        /// دریافت گروه ها
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        private async Task<List<ProductCategoryViewModel>> GetSubGroups(int? categoryId)
        {
            List<ProductGroup> groups;
            if (categoryId == null)
                groups = await GetBaseGroups();
            else
                groups = await GetSubGroupsWithParent((int)categoryId);
            return GetCategoryModel(groups);
        }

        private List<ProductCategoryViewModel> GetCategoryModel(List<ProductGroup> groups)
        {
            return groups.Select(x => new ProductCategoryViewModel()
            {
                CurrentGroup = x.ToModel()
            }).ToList();
        }

        /// <summary>
        /// دریافت گروه هایی که پدرشان آیدی داده شده است
        /// </summary>
        /// <returns></returns>
        private async Task<List<ProductGroup>> GetSubGroupsWithParent(int categoryId)
        {
            return await Queryable.Where(x => x.ParentId == categoryId).ToListAsync();
        }

        /// <summary>
        /// دریافت گروه هایی که پدر ندارند
        /// </summary>
        /// <returns></returns>
        private async Task<List<ProductGroup>> GetBaseGroups()
        {
            return await Queryable.Where(x => x.ParentId == null).ToListAsync();
        }

        /// <summary>
        /// تبدیل لیست دیتابیس به مدل هدر
        /// </summary>
        /// <param name="allActives"></param>
        /// <returns></returns>
        private async Task<List<ProductGroupModel>> GetHeader2Model(List<ProductGroup> allActives)
        {
            var model = new List<ProductGroupModel>();
            //پیمایش همه
            foreach (var productGroup in allActives)
            {
                var temp = productGroup.ToModel();
                var children = await GetByParentId(productGroup.Id);
                if (children != null && children.Any())
                {
                    temp.ProductGroups = await GetHeader2Model(children);
                }

                model.Add(temp);
            }

            return model;
        }

        /// <summary>
        /// تبدیل لیست دیتابیس به مدل هدر
        /// </summary>
        /// <param name="allActives"></param>
        /// <returns></returns>
        private List<LinkGroupHeaderViewModel> GetHeaderModel(List<ProductGroup> allActives)
        {
            var model = new List<LinkGroupHeaderViewModel>();
            //پیمایش همه
            foreach (var productGroup in allActives)
            {
                //اگر پدر نداشت خودش گروه اصلی است
                if (productGroup.ParentId == null)
                {
                    //افزودن به عنوان پدر
                    model = AddAsParent(model, productGroup);
                }
                else
                {
                    //اگر گدر داشت زیر مجموعه پدر اضافه می شود
                    var parent = GetParent(productGroup.ParentId, allActives);
                    if (parent == null)
                    {
                        //افزودن به عنوان پدر
                        model = AddAsParent(model, productGroup);
                    }
                    else
                    {
                        //پیدا کردن پدر اصلی
                        var parentModel = model.FirstOrDefault(x => x.Id == parent.Id);
                        //افزودن به عنوان زیر گروه
                        parentModel?.SubGroups.Add(new LinkSubGroupViewModel()
                        {
                            Id = productGroup.Id,
                            Name = productGroup.Title
                        });
                    }
                }
            }

            return model;
        }

        private List<LinkGroupHeaderViewModel> AddAsParent(List<LinkGroupHeaderViewModel> model, ProductGroup productGroup)
        {
            model.Add(new LinkGroupHeaderViewModel()
            {
                Id = productGroup.Id,
                Name = productGroup.Title
            });
            return model;
        }

        private ProductGroup? GetParent(int? productGroupParentId, List<ProductGroup> allActives)
        {
            //finding main parent
            var parent = allActives.FirstOrDefault(x => x.Id == productGroupParentId);
            if (parent == null) return null;
            //if parent is sub of other group
            if (parent.ParentId != null)
            {
                //find grand parent
                var tempParent = GetParent(parent.ParentId, allActives);
                //return if parent is not valid
                if (tempParent == null) return null;
                //set grand parent as direct parent
                parent = tempParent;
            }
            return parent;
        }


        #endregion
        #region Ctor
        public ProductGroupService(ApplicationDbContext db, IProductService productService, IBrandService brandService) : base(db)
        {
            _productService = productService;
            _brandService = brandService;
        }
        #endregion

    }
}