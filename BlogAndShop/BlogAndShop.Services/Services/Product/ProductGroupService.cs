using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.Utilities;
using BlogAndShop.Services.Classes;
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
            var allActives = await GetProductCategoryViewModel();
            var model = GetHeaderModel(allActives);
            return model;
        }

        public async Task<List<ProductGroupModel>> GetHeaderNastedModel()
        {
            var allParents = await GetProductCategoryViewModel();
            var model = await GetHeader2Model(allParents);
            return model;
        }

        public async Task<ProductCategoryViewModel> GetGroupsModel(int? categoryId)
        {
            return await GetProductCategoryViewModel(categoryId);
        }

        public async Task<Dictionary<int, ProductCategoryViewModel>> GetCategoriesDictionaryFromCache()
        {
            if (CacheHelper.ProductCategoryReference == null)
                await CreateProductCategoryViewModel();
            return CacheHelper.ProductCategoryReference;
        }

        public async Task<ProductListViewModel> GetProductModel(int? categoryId, int? brandId, int page, int count)
        {
            var currentGroup = await GetCurrentGroup(categoryId);
            var products = await _productService.GetProductByGroup(categoryId, brandId, count, page, this);
            var brand = brandId == null ? null : await _brandService.GetByIdAsync((int)brandId);
            var result = new ProductListViewModel()
            {
                CurrentGroup = currentGroup.CurrentGroup,
                Products = products.List.Select(x => _productService.GetProductMiniModel(x)).ToList(),
                ListPaginationModel = new ListPaginationModel(products.TotalCount > page * count, hasPre: page > 1, page: page, count: products.List.Count, pagesCount: ((products.TotalCount - 1) / count) + 1),
                Brand = brand?.ToModel(),
                TotalCount = products.TotalCount
            };
            result.Keywords = GetKeywords(result.CurrentGroup, result.Products);
            result.HeaderText = GetHeaderGroupName(result, currentGroup.ParentGroupName);
            return result;
        }


        public async Task<List<ProductMiniModel>> GetSuggestedProduct(int productId, int groupId, int count = 4)
        {
            var productsWithGroup = await _productService.GetProductByGroup(groupId, brandId: null, count: count, page: 1, this);
            var result = CreateSuggestModel(productsWithGroup.List, productId);
            if (result.Count >= count)
                return result;
            var suggestedGroups = new List<int?>();
            //while (result.Count < count)
            //{
            var suggestedGroup = await GetSuggestedGroup(groupId, suggestedGroups);
            if (suggestedGroup != null)
                suggestedGroups.Add(suggestedGroup);
            var temp = await GetGroupProducts(productId, count, suggestedGroup);
            result.AddRange(temp);
            //}
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
            var dictionary = await GetCategoriesDictionaryFromCache();
            ProductCategoryViewModel group;
            if (dictionary.ContainsKey(categoryId))
                group = dictionary[categoryId];
            else
            {
                var entity = await GetByIdAsync(categoryId);
                group = new ProductCategoryViewModel(entity.ToModel());
            }
            var children = GetChildren(group);
            return children;
        }


        public async Task<ProductCategoryViewModel> GetGroupsHasProductsModel(int? categoryId)
        {
            var result = await GetGroupsModel(categoryId);
            result = await CheckProducts(result);
            return result;
        }




        #endregion
        #region Utilities

        private List<int> GetChildren(ProductCategoryViewModel group)
        {
            var children = new List<int>();
            if (@group.SubCategories != null)
                foreach (var model in @group.SubCategories)
                {
                    var temp = GetChildren(model);
                    children.AddRange(temp);
                }

            children.Add(group.CurrentGroup.Id);
            return children;
        }

        /// <summary>
        /// دریافت درخت زیر مجموعه ها
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        private async Task<ProductCategoryViewModel> GetProductCategoryViewModel(int? categoryId = null)
        {
            if (CacheHelper.ProductCategoryViewModel == null)
                await CreateProductCategoryViewModel();

            return categoryId == null
                ? CacheHelper.ProductCategoryViewModel
                : CacheHelper.ProductCategoryReference[(int)categoryId];

        }
        /// <summary>
        /// تبدیل همه گروه ها به درخت زیر مجموعه ها
        /// </summary>
        /// <returns></returns>
        private async Task CreateProductCategoryViewModel()
        {
            //اگر درحال مقدار دهی بود
            if (CacheHelper.ProductCategoryReferenceLock)
            {
                //انتظار برای پایان مقدار دهی
                while (CacheHelper.ProductCategoryReferenceLock)
                {

                }
                return;
            }
            //آغاز مقدار دهی
            CacheHelper.ProductCategoryReferenceLock = true;
            CacheHelper.ProductCategoryReference = new Dictionary<int, ProductCategoryViewModel>();
            var all = await GetAllAsync();
            var parents = GetParents(all);
            var tree = await CreateTree(parents, all, null);
            var list = new ProductCategoryViewModel(tree);
            CacheHelper.ProductCategoryViewModel = list;
            //پایان مقدار دهی
            CacheHelper.ProductCategoryReferenceLock = false;

        }
        /// <summary>
        /// یافتن سرگروه ای اصلی
        /// </summary>
        /// <param name="all"></param>
        /// <returns></returns>
        private List<ProductGroup> GetParents(List<ProductGroup> all)
        {
            return all.Where(x => x.ParentId == null).ToList();
        }

        /// <summary>
        /// ابجاد درخت نهایی
        /// </summary>
        /// <param name="parents"></param>
        /// <param name="all"></param>
        /// <param name="parentGroupName"></param>
        /// <returns></returns>
        private async Task<List<ProductCategoryViewModel>> CreateTree(List<ProductGroup> parents, List<ProductGroup> all, string parentGroupName)
        {
            var result = new List<ProductCategoryViewModel>();
            foreach (var productGroup in parents)
            {

                var children = GetChildren(productGroup, all);
                //all products in group
                var products = await _productService.GetProductBySpecificGroup(productGroup.Id);
                var imagePath = !string.IsNullOrEmpty(productGroup.ImageUrl) ? productGroup.ImageUrl : products.LastOrDefault(x => !string.IsNullOrEmpty(x.BannerImage))?.BannerImage;
                var groupModel = productGroup.ToModel();
                var newParentGroupName = string.IsNullOrEmpty(parentGroupName)
                     ? groupModel.Title
                     : parentGroupName + " - " + groupModel.Title;
                var temp = new ProductCategoryViewModel(
                     groupModel,
                     await CreateTree(children, all, newParentGroupName),
                     products.Count,
                     imagePath,
                     parentGroupName);
                CacheHelper.ProductCategoryReference.Add(productGroup.Id, temp);
                result.Add(temp);
            }

            return result;
        }


        /// <summary>
        /// یافتن زیر مجموعه ها بر اساس پدر داده شده
        /// </summary>
        /// <param name="productGroup"></param>
        /// <param name="all"></param>
        /// <returns></returns>
        private List<ProductGroup> GetChildren(ProductGroup productGroup, List<ProductGroup> all)
        {
            return all.Where(x => x.ParentId == productGroup.Id).ToList();
        }


        /// <summary>
        /// چک کردن وجود محصول و تنظیم تصویر
        /// </summary>
        /// <returns></returns>
        private async Task<ProductCategoryViewModel> CheckProducts(ProductCategoryViewModel model)
        {
            model.SubCategories = model.SubCategories.Where(x => x.HasProduct).ToList();
            return model;
        }

        /// <summary>
        /// بازگرداندن نام سربرگ محصولات
        /// </summary>
        /// <param name="result"></param>
        /// <param name="parentName"></param>
        /// <returns></returns>
        private string GetHeaderGroupName(ProductListViewModel result, string parentName)
        {
            var titles = new List<string>();
            if (!string.IsNullOrEmpty(parentName)) titles.Add(parentName);
            if (!string.IsNullOrEmpty(result.Brand?.Name)) titles.Add(result.Brand?.Name);
            if (!string.IsNullOrEmpty(result.CurrentGroup?.Title)) titles.Add(result.CurrentGroup?.Title);
            var text = string.Join(" - ", titles);
            return string.IsNullOrEmpty(text) ? "همه محصولات" : text;
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
        private async Task<ProductCategoryViewModel> GetCurrentGroup(int? categoryId)
        {
            return await GetProductCategoryViewModel(categoryId);
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
            return groups.Select(x => new ProductCategoryViewModel(x.ToModel())).ToList();
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
        private async Task<List<ProductGroupModel>> GetHeader2Model(ProductCategoryViewModel allActives)
        {
            var model = new List<ProductGroupModel>();
            //پیمایش همه
            foreach (var productGroup in allActives.SubCategories)
            {
                var temp = await GetHeader2Model(productGroup);
                var current = productGroup.CurrentGroup;
                current.ProductGroups = temp;
                model.Add(current);
            }

            return model;
        }

        /// <summary>
        /// تبدیل لیست دیتابیس به مدل هدر
        /// </summary>
        /// <param name="allActives"></param>
        /// <returns></returns>
        private List<LinkGroupHeaderViewModel> GetHeaderModel(ProductCategoryViewModel allActives)
        {
            //تبدیل تمام گروه های که محصول دارند به مدل هدر
            var model = allActives.SubCategories.Where(x => x.HasProduct).Select(x => new LinkGroupHeaderViewModel
            {
                Id = x.CurrentGroup.Id,
                Name = x.CurrentGroup.Title,
                SubGroups = GetSubGroups(x)
            }).ToList();


            return model;
        }
        /// <summary>
        /// دریافت زیر گروه های مجموعه برای مدل هدر
        /// </summary>
        /// <returns></returns>
        private List<LinkSubGroupViewModel> GetSubGroups(ProductCategoryViewModel model)
        {
            var result = new List<LinkSubGroupViewModel>();
            result.Add(new LinkSubGroupViewModel()
            {
                Id = model.CurrentGroup.Id,
                Name = model.CurrentGroup.Title
            });
            //زیر گروه هایی که محصول دارند
            var subs = model.SubCategories.Where(x => x.HasProduct);
            foreach (var sub in subs)
            {
                var temp = GetSubGroups(sub);
                result.AddRange(temp);
            }
            return result;
        }

        #endregion
        #region Ctor
        public ProductGroupService(ApplicationDbContext db, IProductService productService, IBrandService brandService) : base(db)
        {
            _productService = productService;
            _brandService = brandService;
            DataHelper.ProductGroups = db.Set<ProductGroup>().ToList();
        }
        #endregion

    }
}