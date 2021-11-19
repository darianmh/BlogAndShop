using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.User;

namespace BlogAndShop.Data.ViewModel.PaymentInfo
{
    /// <summary>
    ///  موارد موجود در سبد خرید کاربر
    /// </summary>
    public class CartItemModel : BaseEntityModel
    {
        /// <summary>
        /// ProductId
        /// </summary>
        [ForeignKey("Product")]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int ProductId { get; set; }

        /// <summary>
        /// CartId
        /// </summary>
        [ForeignKey("UserCart")]
        [Display(Name = "سبد خرید")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int CartId { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int Quantity { get; set; }



        //np
        public virtual UserCartModel UserCart { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}