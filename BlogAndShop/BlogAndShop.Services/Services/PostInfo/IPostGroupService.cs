using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.PostInfo
{
    public interface IPostGroupService : IMainService<PostGroup>
    {
        Task<List<LinkGroupHeaderViewModel>> GetHeaderModel();
        /// <summary>
        /// دریافت لیست پست ها بر اساس گروه
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<BlogListViewModel> GetPostModel(int? categoryId, int page, int count);

        ///  <summary>
        ///  لیستی از گروه ها داده می شود و نام گروه مورد نظر یافت می شود.
        /// گروه ها از پدر به فرزند مرتب شده اند
        ///  </summary>
        ///  <param name="catNames"></param>
        ///  <returns></returns>
        Task<PostGroup> GetCatByName(string[] catNames);
    }
}
