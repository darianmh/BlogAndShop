using System;
using System.Linq;
using System.Reflection;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Mvc.Razor;

namespace BlogAndShop.Services
{
    public static class ViewHelper
    {
        /// <summary>
        /// get attr that holds controller info and name
        /// </summary>
        /// <param name="pageBase"></param>
        /// <returns></returns>
        public static AdminFilterNameAttribute GetInfo(this RazorPageBase pageBase)
        {
            var controllerName = pageBase.ViewContext.RouteData?.Values["controller"]?.ToString();
            var type = AssemblyHelper.AdminControllers.FirstOrDefault(x => x.Name.Equals((controllerName + "Controller"), StringComparison.InvariantCultureIgnoreCase));
            var controllerInfo = (AdminFilterNameAttribute)type?.GetCustomAttribute(typeof(AdminFilterNameAttribute));
            return controllerInfo ?? new AdminFilterNameAttribute(AdminControllerNames.Common, controllerName);
        }
    }
}
