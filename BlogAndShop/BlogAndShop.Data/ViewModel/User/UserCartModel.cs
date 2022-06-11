using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using CommonConfiguration.Core.Data.Data.User;
using CommonConfiguration.Core.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.User;

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
        [DbOptionList(typeof(ApplicationUser), false)]
        [AdminShowItem(1)]
        public int OwnerId { get; set; }


        [Ignore]
        public decimal TotalPrice { get; set; }
        [Ignore]
        public decimal OffPrice { get; set; }
        [Ignore]
        //مبلغ قابل پرداخت
        [AdminShowItem(2)]
        public decimal ToPayPrice { get; set; }

        //np
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
        [Ignore]
        public virtual List<CartItemModel> CartItems { get; set; }
    }
}