using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
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
        [DbOptionList(typeof(Data.Product.Product), false)]
        public int ProductId { get; set; }

        /// <summary>
        /// CartId
        /// </summary>
        [ForeignKey("UserCart")]
        [Display(Name = "سبد خرید")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(UserCart), false)]
        public int CartId { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int Quantity { get; set; }



        //np
        [Ignore]
        public virtual UserCartModel UserCart { get; set; }
        [Ignore]
        public virtual ProductModel Product { get; set; }


        //extra entity
        [Ignore]
        public decimal TotalPrice { get; set; }
        public decimal OffPriceTotal { get; set; }
    }
}