using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.User.Identity;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogAndShop.Services
{
    public static class SiteInfoHelper
    {
        #region Fields


        #endregion
        #region Methods

        public static async Task<string> GetUserName(this IHtmlHelper helper)
        {
            var user = helper.ViewContext.HttpContext.User.Identity?.Name;
            if (user == null) return "";
            var userManager =
                (ApplicationUserManager)helper.ViewContext.HttpContext.RequestServices.GetService(
                    typeof(ApplicationUserManager));
            if (userManager == null) return "";
            return await userManager.GetUSerDisplayNameAsync(user);
        }
        public static async Task<string> GetSiteIcon(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.SiteIcon;
        }
        public static async Task<string> GetSiteIcon512(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.SiteIcon512;
        }
        public static async Task<string> GetSiteLogo(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.LogoFile;
        }
        public static async Task<string> GetSiteName(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.Title;
        }
        public static async Task<string> GetSiteKeywords(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.Keywords;
        }
        public static async Task<string> GetSiteDescription(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.Description;
        }
        public static async Task<string> GetSiteContactPhone(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.PhoneNumber;
        }
        public static async Task<string> GetSiteContactEmail(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.Email;
        }
        public static async Task<string> GetSiteContactAddress(this IHtmlHelper helper)
        {
            var model = await GetSiteInfo(helper);
            return model.Address;
        }
        #endregion
        #region Utilities

        public static async Task<SiteConfigModel> GetSiteInfo(IHtmlHelper helper)
        {
            var service = GetServiceInstance<ISiteConfigService>(helper.ViewContext.HttpContext);
            if (service == null) return new SiteConfigModel();
            var model = await service.GetInfo();
            return model;
        }
        private static T GetServiceInstance<T>(HttpContext httpContext)
        {
            var service = (T)httpContext.RequestServices.GetService(typeof(T));
            return service;
        }

        #endregion

    }
}
