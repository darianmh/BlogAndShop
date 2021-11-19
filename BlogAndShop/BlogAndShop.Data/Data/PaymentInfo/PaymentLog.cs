using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PaymentInfo
{
    /// <summary>
    ///  تلاش های پرداخت 
    /// </summary>
    public class PaymentLog : BaseEntity
    {
        /// <summary>
        /// فاکتور
        /// </summary>
        [ForeignKey("Payment")]
        [Display(Name = "فاکتور")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public int PaymentId { get; set; }

        /// <summary>
        ///  منتظر، پرداخت شده، پرداخت ناموفق، لغو شده
        /// </summary>
        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(2)]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        //np
        [JsonIgnore]
        public virtual Payment Payment { get; set; }
    }
}