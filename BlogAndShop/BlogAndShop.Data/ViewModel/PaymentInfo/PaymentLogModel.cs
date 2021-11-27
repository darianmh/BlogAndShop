using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.PaymentInfo
{
    /// <summary>
    ///  تلاش های پرداخت 
    /// </summary>
    public class PaymentLogModel : BaseEntityModel
    {
        /// <summary>
        /// فاکتور
        /// </summary>
        [ForeignKey("Payment")]
        [Display(Name = "فاکتور")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Payment), false)]
        public int PaymentId { get; set; }

        /// <summary>
        ///  منتظر، پرداخت شده، پرداخت ناموفق، لغو شده
        /// </summary>
        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [EnumList(typeof(PaymentStatus))]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        [Display(Name = "توضیحات")]
        [TextArea]
        public string Description { get; set; }

        //np
        [Ignore]
        public virtual PaymentModel Payment { get; set; }
    }
}