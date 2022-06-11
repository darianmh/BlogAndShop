using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.HomePage;
using BlogAndShop.Data.ViewModel.LearningSystem;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;
using CommonConfiguration.Core.Data.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
        [AdminShowItem(3)]
        [IsMedia]
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

        /// <summary>
        /// آیا فایل آپلود شده به فرمت وبپی تبدیل شود یا خیر
        /// اگر ممکن بود
        /// </summary>
        [Display(Name = "تبدیل به webp")]
        public bool ToWebp { get; set; }



        //np
        [Ignore]
        public virtual List<ProductMediaModel> ProductMedias { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<BrandModel> Brands { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<PostModel> Posts { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<HomeBannerModel> HomeBanners { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<LearningSiteConfigViewModel> LearningSiteConfigs { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<Product.ProductModel> Products { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<Course> Courses { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<ProductGroupModel> ProductGroups { get; set; }

    }
}