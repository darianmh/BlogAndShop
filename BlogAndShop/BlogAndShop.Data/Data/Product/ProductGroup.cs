using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    /// <summary>
    ///   گروه بندی محصولات 
    /// </summary>
    public class ProductGroup : BaseEntity
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        [Display(Name = "توضیحات")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        ///  اگر زیر مجموعه باشد
        /// </summary>
        [Display(Name = "سرگروه")]
        [AdminShowItem(3)]
        public int? ParentId { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        [Display(Name = "تصویر")]
        [AdminShowItem(4)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// کلمات کلیدی
        /// </summary>
        [Display(Name = "کلمات کلیدی")]
        [AdminShowItem(5)]
        public string Keywords { get; set; }

        //np
        [JsonIgnore]
        public virtual List<Product> Products { get; set; }


        public override MySelectListItem GetSelectListItem(string selected)
        {
            return new MySelectListItem(Title, Id.ToString(), Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase));
        }
    }
}