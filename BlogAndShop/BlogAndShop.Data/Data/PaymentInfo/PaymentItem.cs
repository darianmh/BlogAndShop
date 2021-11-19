using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PaymentInfo
{
    /// <summary>
    ///      محصولات موجود در قاکتور
    /// </summary>
    public class PaymentItem : BaseEntity
    {

        /// <summary>
        /// فاکتور
        /// </summary>
        [ForeignKey("Payment")]
        [Display(Name = "فاکتور")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int PaymentId { get; set; }

        /// <summary>
        /// محصول
        /// </summary>
        [ForeignKey("Product")]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int ProductId { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int Quantity { get; set; }

        /// <summary>
        ///  مبلغ پایه
        /// </summary>
        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public decimal Amount { get; set; }

        /// <summary>
        ///  میزان تخفیف
        /// </summary>
        [Display(Name = "میزان تخفیف")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public decimal OffAmount { get; set; }




        //np
        [JsonIgnore]
        public virtual Payment Payment { get; set; }
        [JsonIgnore]
        public virtual Product.Product Product { get; set; }
    }
}