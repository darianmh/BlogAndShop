using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PaymentInfo
{
    /// <summary>
    ///  موارد موجود در سبد خرید کاربر
    /// </summary>
    public class CartItem : BaseEntity
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
        [JsonIgnore]
        public virtual UserCart UserCart { get; set; }
        [JsonIgnore]
        public virtual Product.Product Product { get; set; }
    }
}