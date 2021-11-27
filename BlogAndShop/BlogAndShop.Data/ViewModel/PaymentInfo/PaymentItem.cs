using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;

namespace BlogAndShop.Data.ViewModel.PaymentInfo
{
    /// <summary>
    ///      محصولات موجود در قاکتور
    /// </summary>
    public class PaymentItemModel : BaseEntityModel
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
        /// محصول
        /// </summary>
        [ForeignKey("Product")]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Data.Product.Product), false)]
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
        [Ignore]
        public virtual PaymentModel Payment { get; set; }
        [Ignore]
        public virtual ProductModel Product { get; set; }
    }
}