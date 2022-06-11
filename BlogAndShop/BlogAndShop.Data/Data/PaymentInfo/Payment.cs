using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using CommonConfiguration.Core.Data.Data.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PaymentInfo
{
    /// <summary>
    ///  فاکتور خرید نهایی
    /// </summary>
    public class Payment : BaseEntity
    {

        /// <summary>
        /// کاربر
        /// </summary>
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public int OwnerId { get; set; }

        /// <summary>
        ///  مبلغ پایه
        /// </summary>
        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public decimal Amount { get; set; }

        /// <summary>
        ///  میزان تخفیف
        /// </summary>
        [Display(Name = "تخفیف")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public decimal OffAmount { get; set; }

        /// <summary>
        ///  مبلغ قابل پرداخت نهایی
        /// </summary>
        [Display(Name = "مبلغ نهایی")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(2)]
        public decimal FinalAmount { get; set; }

        /// <summary>
        /// آدرس ارسال
        /// </summary>
        [ForeignKey("Address")]
        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int AddressId { get; set; }

        /// <summary>
        ///  منتظر، پرداخت شده، پرداخت ناموفق، لغو شده
        /// </summary>
        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// متن برای معرفی محصول به ادمین
        /// هدف نکته مشتری نیست
        /// </summary>
        [Display(Name = "متن")]
        public string Text { get; set; }




        //np
        [JsonIgnore]
        public virtual Address Address { get; set; }
        [JsonIgnore]
        public virtual List<PaymentItem> PaymentItems { get; set; }
        [JsonIgnore]
        public virtual List<PaymentLog> PaymentLogs { get; set; }
    }
}