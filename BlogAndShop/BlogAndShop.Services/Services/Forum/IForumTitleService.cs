﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Forum
{
    public interface IForumTitleService : IMainService<ForumTitle>
    {
        /// <summary>
        /// دریافت مدل فروم های لینک شده به محصول
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<List<ForumTitleModel>> GetProductForumsModel(int productId);
        /// <summary>
        /// ایجاد یک انجمن برای محصول
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task CreateProductForum(Data.Data.Product.Product item);

        /// <summary>
        /// سایت مپ را از تولید می کند از تمام موارد
        /// </summary>
        /// <returns></returns>
        Task<List<SiteMapItemModel>> GetSiteMap();

        /// <summary>
        /// جستجو در بین موارد موجود
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<List<SearchResultItemModel>> Search(string key);
    }
}
