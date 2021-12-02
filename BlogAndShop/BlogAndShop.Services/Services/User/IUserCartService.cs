using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.User;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.User
{
    public interface IUserCartService : IMainService<UserCart>
    {
        /// <summary>
        /// اولین سبد خرید موجود برای کاربر را بر میگرداند
        /// اگر موجود نبود میسازد
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<UserCart> GetUserCart(int userId);
        /// <summary>
        /// دریافت مدل نهای سبد خرید کاربر
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<UserCartModel> GetUserCartModel(int userId);
    }
}
