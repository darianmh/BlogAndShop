using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.PaymentInfo;
using CommonConfiguration.Core.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.User;

namespace BlogAndShop.Data.Data.User
{
    /// <summary>
    /// آدرس های کاربر 
    /// </summary>
    public class Address : BaseEntity
    {
        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public int OwnerId { get; set; }

        /// <summary>
        /// شهر
        /// </summary>
        [Display(Name = "شهر")]
        [AdminShowItem(2)]
        public string City { get; set; }

        /// <summary>
        /// خیابان
        /// </summary>
        [Display(Name = "خیابان")]
        [AdminShowItem(3)]
        public string Street { get; set; }

        /// <summary>
        /// خیابان فرعی
        /// </summary>
        [Display(Name = "خیابان فرعی")]
        public string SecondaryStreet { get; set; }

        /// <summary>
        /// کوچه
        /// </summary>
        [Display(Name = "کوچه")]
        public string Alley { get; set; }

        /// <summary>
        /// پلاک
        /// </summary>
        [Display(Name = "پلاک")]
        public string Number { get; set; }

        /// <summary>
        /// ادامه
        /// </summary>
        [Display(Name = "جزییات")]
        public string Details { get; set; }


        //np
        public virtual List<Payment> Payments { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}