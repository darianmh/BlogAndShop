using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    ///  نظرات برای محصول
    /// </summary>
    public class ProductCommentModel : BaseEntityModel
    {
        /// <summary>
        /// ProductId
        /// </summary>
        [ForeignKey("Product")]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Data.Product.Product), false)]
        [AdminShowItem(2)]
        public int ProductId { get; set; }

        /// <summary>
        ///      اگر ریپلای باشد این فیلد مقدار می گیرد
        /// </summary>
        [ForeignKey("ParentProductComment")]
        [Display(Name = "پدر")]
        [DbOptionList(typeof(ProductComment), true)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [TextArea]
        [AdminShowItem(1)]
        public string Text { get; set; }

        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("Owner")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [Hidden]
        public int OwnerId { get; set; }

        /// <summary>
        ///  ادمین باید هر کامنت را تایید کند
        /// </summary>
        [Display(Name = "تایید شده؟")]
        public bool IsAccepted { get; set; }
        /// <summary>
        /// وضعیت مشاهده این درخواست
        /// </summary>
        [Display(Name = "وضعیت مشاهده")]
        [EnumList(typeof(MessageStatus))]
        [AdminShowItem(3)]
        public MessageStatus MessageStatus { get; set; }



        //np
        [Ignore]
        public virtual ProductModel Product { get; set; }
        [Ignore]
        public virtual ApplicationUserModel Owner { get; set; }
        [Ignore]
        public virtual List<ProductCommentModel> ProductComments { get; set; }
        [Ignore]
        public virtual ProductCommentModel ParentProductComment { get; set; }
    }
}