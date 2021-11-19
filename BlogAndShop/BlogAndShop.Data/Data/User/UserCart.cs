using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.PaymentInfo;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.User
{
    /// <summary>
    /// سبد خرید کاربر
    /// </summary>
    public class UserCart : BaseEntity
    {

        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int OwnerId { get; set; }


        //np
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        [JsonIgnore]
        public virtual List<CartItem> CartItems { get; set; }
    }
}