using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Utilities;
using BlogAndShop.Services.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnumListAttribute = BlogAndShop.Data.Classes.EnumListAttribute;
using HtmlEditAttribute = BlogAndShop.Data.Classes.HtmlEditAttribute;

namespace BlogAndShop.ViewComponents
{
    public class EditCreateTemplate : ViewComponent
    {
        #region Fields

        #endregion
        #region Methods

        /// <summary>
        /// سازنده قالب برای صفحه ویرایش و ساخت
        /// </summary>
        /// <typeparam name="T">مدل موجود در صفحه</typeparam>
        /// <param name="model"></param>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync(object model, HttpContext httpContext)
        {
            var helper = new EditCreateTemplateHelper();
            var result = await helper.GetModel(model, httpContext);
            return View(result);
        }

        #endregion
        #region Ctor

        public EditCreateTemplate()
        {

        }
        #endregion

    }
}