using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    /// <summary>
    ///  نظرات برای محصول
    /// </summary>
    public class ProductComment : BaseEntity
    {
        /// <summary>
        /// ProductId
        /// </summary>
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public int ProductId { get; set; }

        /// <summary>
        ///      اگر ریپلای باشد این فیلد مقدار می گیرد
        /// </summary>
        [ForeignKey("ParentProductComment")]
        [Display(Name = "پدر")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(2)]
        public string Text { get; set; }

        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("Owner")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public int OwnerId { get; set; }

        /// <summary>
        ///  ادمین باید هر کامنت را تایید کند
        /// </summary>
        [Display(Name = "تایید شده؟")]
        [AdminShowItem(4)]
        public bool IsAccepted { get; set; }

        /// <summary>
        /// وضعیت مشاهده این درخواست
        /// </summary>
        [Display(Name = "وضعیت مشاهده")]
        [EnumList(typeof(MessageStatus))]
        public MessageStatus MessageStatus { get; set; }


        //np
        [JsonIgnore]
        public virtual Product Product { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser Owner { get; set; }
    }
}