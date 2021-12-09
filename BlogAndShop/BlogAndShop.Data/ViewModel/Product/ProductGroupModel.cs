﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    ///   گروه بندی محصولات 
    /// </summary>
    public class ProductGroupModel : BaseEntityModel
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
        [HtmlEdit]
        [AdminShowItem(1)]
        public string Description { get; set; }

        /// <summary>
        ///  اگر زیر مجموعه باشد
        /// </summary>
        [ForeignKey("ParentProductGroup")]
        [Display(Name = "سرگروه")]
        [DbOptionList(typeof(ProductGroup), true)]
        public int? ParentId { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        [Display(Name = "تصویر")]
        [FileUpload]
        public string ImageUrl { get; set; }
        /// <summary>
        /// کلمات کلیدی
        /// </summary>
        [Display(Name = "کلمات کلیدی")]
        [FileUpload]
        public string Keywords { get; set; }

        //np
        [Ignore]
        public virtual List<ProductModel> Products { get; set; }
        [Ignore]
        public virtual List<ProductGroupModel> ProductGroups { get; set; }
        [Ignore]
        public virtual ProductGroupModel ParentProductGroup { get; set; }
    }
}