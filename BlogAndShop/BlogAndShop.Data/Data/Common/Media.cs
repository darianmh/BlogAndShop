using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Product;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Common
{
    /// <summary>
    /// ذخیره فایل ها در سایت 
    /// یا ذخیره در سی دی ان و نگهداری آدرس آنها
    /// </summary>
    public class Media : BaseEntity
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Display(Name = "عنوان")]
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        [Display(Name = "توضیحات")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        /// آدرس سی دی ان  یا سایت خودمان
        /// </summary>
        [Display(Name = "آدرس")]
        public string Path { get; set; }

        /// <summary>
        /// عنوان پسوند فایل
        /// </summary>
        [Display(Name = "پسوند")]
        public string Extension { get; set; }


        //np
        [JsonIgnore]
        public virtual List<ProductMedia> ProductMedias { get; set; }


        public override SelectListItem GetSelectListItem(string selected)
        {
            return new SelectListItem(Title, Id.ToString(), Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase));
        }

        public override string GetShowTextById(string id)
        {
            return Title;
        }

        public override bool Find(string id)
        {
            return base.Find(id);
        }
    }
}