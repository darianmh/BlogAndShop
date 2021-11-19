using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PaymentInfo;

namespace BlogAndShop.Data.ViewModel.User
{
    /// <summary>
    /// سبد خرید کاربر
    /// </summary>
    public class UserCartModel : BaseEntityModel
    {

        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int OwnerId { get; set; }


        //np
        public virtual ApplicationUserModel User { get; set; }
        public virtual List<CartItemModel> CartItems { get; set; }
    }
}