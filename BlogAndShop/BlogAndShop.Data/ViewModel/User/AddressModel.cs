using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PaymentInfo;

namespace BlogAndShop.Data.ViewModel.User
{
    /// <summary>
    /// آدرس های کاربر 
    /// </summary>
    public class AddressModel : BaseEntityModel
    {
        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int OwnerId { get; set; }

        /// <summary>
        /// شهر
        /// </summary>
        [Display(Name = "شهر")]
        public string City { get; set; }

        /// <summary>
        /// خیابان
        /// </summary>
        [Display(Name = "خیابان")]
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
        public virtual List<PaymentModel> Payments { get; set; }
        public virtual ApplicationUserModel User { get; set; }

    }
}