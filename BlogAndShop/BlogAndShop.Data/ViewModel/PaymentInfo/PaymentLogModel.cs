using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int PaymentId { get; set; }

        /// <summary>
        ///  منتظر، پرداخت شده، پرداخت ناموفق، لغو شده
        /// </summary>
        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        //np
        public virtual PaymentModel Payment { get; set; }
    }
}