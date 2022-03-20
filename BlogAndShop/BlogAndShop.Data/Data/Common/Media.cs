using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.HomePage;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        /// <summary>
        /// آیا فایل آپلود شده به فرمت وبپی تبدیل شود یا خیر
        /// اگر ممکن بود
        /// </summary>
        [Display(Name = "تبدیل به webp")]
        public bool ToWebp { get; set; }


        //np
        [JsonIgnore]
        public virtual List<ProductMedia> ProductMedias { get; set; }
        [JsonIgnore]
        public virtual List<Brand> Brands { get; set; }
        [JsonIgnore]
        public virtual List<Post> Posts { get; set; }
        [JsonIgnore]
        public virtual List<HomeBanner> HomeBanners { get; set; }
        [JsonIgnore]
        public virtual List<Product.Product> Products { get; set; }
        [JsonIgnore]
        public virtual List<ProductGroup> ProductGroups { get; set; }
        [JsonIgnore]
        public virtual List<DownloadItem> DownloadItems { get; set; }
        [JsonIgnore]
        public virtual List<DownloadItem> DownloadItems1 { get; set; }


        public override MySelectListItem GetSelectListItem(string selected)
        {
            try
            {
                var array = (JArray)JsonConvert.DeserializeObject(selected);
                var selectedValues = array?.Select(Convert.ToInt32)?.ToList() ?? new List<int>();
                return new MySelectListItem(Title, Id.ToString(), selectedValues.Contains(Id), true, Path);
            }
            catch
            {
                return new MySelectListItem(Title, Id.ToString(), Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase), true, Path);
            }
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