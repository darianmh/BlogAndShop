﻿using System;
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

        #endregion
        #region Methods

        public async Task<List<LinkGroupHeaderViewModel>> GetHeaderModel()
        {
            var allActives = await GetAllAsync();
            var model = GetHeaderModel(allActives);
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
            var products = await _productService.GetProductByGroup(categoryId, brandId, count, page);
            return new ProductListViewModel()
            {
                CurrentGroup = currentGroup,
                Products = products.List.Select(x => _productService.GetProductMiniModel(x)).ToList(),
                ListPaginationModel = new ListPaginationModel(products.TotalCount > page * count, hasPre: page > 1, page: page, count: products.List.Count, pagesCount: ((products.TotalCount - 1) / count) + 1)
            };
        }

        public async Task<List<ProductMiniModel>> GetSuggestedProduct(int productId, int groupId, int count = 4)
        {
            var productsWithGroup = await _productService.GetProductByGroup(groupId, brandId: null, count, 1);
            var result = CreateSuggestModel(productsWithGroup.List, productId);
            if (result.Count >= count)
                return result;
            while (result.Count < count)
            {
                var suggestedGroup = await GetSuggestedGroup(groupId);
                var temp = await GetGroupProducts(productId, suggestedGroup, count);
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

        #endregion
        #region Utilities

        private async Task<IEnumerable<ProductMiniModel>> GetGroupProducts(int productId, int suggestedGroup, int count)
        {
            var productsWithGroup = await _productService.GetProductByGroup(suggestedGroup, brandId: null, count, 1);
            return CreateSuggestModel(productsWithGroup.List, productId);
        }


        /// <summary>
        /// دریافت یک پروه مشابه گروه داده شده
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        private async Task<int> GetSuggestedGroup(int groupId)
        {
            var group = await GetByIdAsync(groupId);
            if (group.ParentId != null)
                return group.ParentId.Value;
            return GetRandomId();
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
        public ProductGroupService(ApplicationDbContext db, IProductService productService) : base(db)
        {
            _productService = productService;
        }
        #endregion

    }
}