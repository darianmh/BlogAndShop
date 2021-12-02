using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Product;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    /// <summary>
    /// محصولات
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        ///  توضیحات Html
        /// </summary>
        [Display(Name = "توضیحات HTML")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        /// توضیحات کوتاه
        /// </summary>
        [Display(Name = "توضیحات کوتاه")]
        public string ShortDescription { get; set; }

        /// <summary>
        ///  توضیحات متا سایت
        /// </summary>
        [Display(Name = "توضیحات متا سایت")]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Banner Image
        /// </summary>
        [Display(Name = "تصویر")]
        public string BannerImage { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public int Quantity { get; set; }

        /// <summary>
        /// قیمت اصلی
        /// </summary>
        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(4)]
        public decimal Price { get; set; }

        /// <summary>
        ///    کاربر ایجاد کننده
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int AuthorId { get; set; }
        /// <summary>
        ///    برند
        /// </summary>
        [ForeignKey("Brand")]
        [Display(Name = "برند")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int BrandId { get; set; }

        /// <summary>
        /// ProductGroupId
        /// </summary>
        [ForeignKey("ProductGroup")]
        [Display(Name = "گروه")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(5)]
        public int ProductGroupId { get; set; }

        /// <summary>
        ///  قیمت تخفیف
        /// </summary>
        [Display(Name = "تخفیف")]
        public decimal? OffPrice { get; set; }
        public bool IsPublished { get; set; }


        //np
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        [JsonIgnore]
        public virtual Brand Brand { get; set; }
        [JsonIgnore]
        public virtual ProductGroup ProductGroup { get; set; }
        [JsonIgnore]
        public virtual List<ProductMedia> ProductMedias { get; set; }
        [JsonIgnore]
        public virtual List<CartItem> CartItems { get; set; }
        [JsonIgnore]
        public virtual List<ProductComment> ProductComments { get; set; }
        [JsonIgnore]
        public virtual List<ProductTag> ProductTags { get; set; }
        [JsonIgnore]
        public virtual List<PaymentItem> PaymentItems { get; set; }

    }
}