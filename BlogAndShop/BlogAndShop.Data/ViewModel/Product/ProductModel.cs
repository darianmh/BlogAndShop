using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.User;

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
        [Ignore]
        public string BannerImage { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "{0} الزامی است")]
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
        public decimal? OffPrice { get; set; }


        //np
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
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
        public virtual List<BrandModel> Brands { get; set; }
        [Ignore]
        public virtual List<PaymentItemModel> PaymentItems { get; set; }

    }
}