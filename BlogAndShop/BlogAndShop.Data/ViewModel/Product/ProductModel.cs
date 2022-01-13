using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    /// محصولات
    /// </summary>
    public class ProductModel : BaseEntityModel
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
        [HtmlEdit]
        public string Description { get; set; }

        /// <summary>
        /// توضیحات کوتاه
        /// </summary>
        [Display(Name = "توضیحات کوتاه")]
        [TextArea]
        public string ShortDescription { get; set; }

        /// <summary>
        ///  توضیحات متا سایت
        /// </summary>
        [Display(Name = "توضیحات متا سایت")]
        [TextArea]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Banner Image
        /// </summary>
        [Display(Name = "تصویر")]
        [FileUpload]
        public string BannerImage { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(2)]
        public int Quantity { get; set; }
        /// <summary>
        /// برند
        /// </summary>
        [Display(Name = "برند")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Brand), false)]
        public int BrandId { get; set; }

        /// <summary>
        /// قیمت اصلی
        /// </summary>
        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public decimal Price { get; set; }

        /// <summary>
        ///    کاربر ایجاد کننده
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [Hidden]
        public int AuthorId { get; set; }

        /// <summary>
        /// ProductGroupId
        /// </summary>
        [ForeignKey("ProductGroup")]
        [Display(Name = "گروه")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(ProductGroup), false)]
        public int ProductGroupId { get; set; }

        /// <summary>
        ///  قیمت تخفیف
        /// </summary>
        [Display(Name = "تخفیف")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(4)]
        public decimal? OffPrice { get; set; }
        [Display(Name = "منتشر شده")]
        [AdminShowItem(5)]
        public bool IsPublished { get; set; }
        [Display(Name = "کلمات کلیدی")]
        [TextArea]
        public string Keywords { get; set; }
        [Ignore]
        public bool SaveAndContinue { get; set; }



        //extra entity
        [DbOptionList(typeof(Tag), true, true)]
        [Display(Name = "تگ ها")]
        public List<int> SelectedTags { get; set; }
        [DbOptionList(typeof(Media), true, true)]
        [Display(Name = "سایر تصویر ها")]
        public List<int> SelectedImages { get; set; }



        //np
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<ProductCallRequestModel> ProductCallRequests { get; set; }
        [Ignore]
        public virtual ProductGroupModel ProductGroup { get; set; }
        [Ignore]
        public virtual List<ProductMediaModel> ProductMedias { get; set; }
        [Ignore]
        public virtual List<CartItemModel> CartItems { get; set; }
        [Ignore]
        public virtual List<ProductCommentModel> ProductComments { get; set; }
        [Ignore]
        public virtual List<ProductTagModel> ProductTags { get; set; }
        [Ignore]
        public virtual BrandModel Brand { get; set; }
        [Ignore]
        public virtual List<PaymentItemModel> PaymentItems { get; set; }
        [Ignore]
        public virtual List<ProductForumGroupModel> ProductForumGroups { get; set; }

    }
}