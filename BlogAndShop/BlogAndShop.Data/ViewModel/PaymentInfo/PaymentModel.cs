using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;

namespace BlogAndShop.Data.ViewModel.PaymentInfo
{
    /// <summary>
    ///  فاکتور خرید نهایی
    /// </summary>
    public class PaymentModel : BaseEntityModel
    {

        /// <summary>
        /// کاربر
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [Hidden]
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
        [DbOptionList(typeof(Address), false)]
        public int AddressId { get; set; }

        /// <summary>
        ///  منتظر، پرداخت شده، پرداخت ناموفق، لغو شده
        /// </summary>
        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [EnumList(typeof(PaymentStatus))]
        [AdminShowItem(3)]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "متن")]
        [TextArea]
        public string Text { get; set; }




        //np
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
        [Ignore]
        public virtual AddressModel Address { get; set; }
        [Ignore]
        public virtual List<PaymentItemModel> PaymentItems { get; set; }
        [Ignore]
        public virtual List<PaymentLogModel> PaymentLogs { get; set; }
    }
}