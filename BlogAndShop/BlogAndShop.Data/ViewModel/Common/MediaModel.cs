using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Product;
using Microsoft.AspNetCore.Http;

namespace BlogAndShop.Data.ViewModel.Common
{
    /// <summary>
    /// ذخیره فایل ها در سایت 
    /// یا ذخیره در سی دی ان و نگهداری آدرس آنها
    /// </summary>
    public class MediaModel : BaseEntityModel
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
        [TextArea]
        public string Description { get; set; }

        /// <summary>
        /// آدرس سی دی ان  یا سایت خودمان
        /// </summary>
        [Display(Name = "آدرس فایل")]
        public string Path { get; set; }

        /// <summary>
        /// عنوان پسوند فایل
        /// </summary>
        [Display(Name = "پسوند")]
        [Hidden]
        [AdminShowItem(2)]
        public string Extension { get; set; }
        [Ignore]
        [Display(Name = "فایل (اگر خالی باشد آدرس اهمیت دارد)")]
        public IFormFile PathFile { get; set; }
        [Ignore]
        public FileType FileType { get; set; }
        //np
        [Ignore]
        public virtual List<ProductMediaModel> ProductMedias { get; set; }

    }
}