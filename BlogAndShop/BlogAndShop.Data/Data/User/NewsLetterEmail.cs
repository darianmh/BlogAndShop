using System.ComponentModel.DataAnnotations;
using CommonConfiguration.Core.Data.Data.Common;

namespace BlogAndShop.Data.Data.User
{
    /// <summary>
    /// ایمیل های عضو خبرنامه
    /// </summary>
    public class NewsLetterEmail : BaseEntity
    {

        /// <summary>
        /// Email
        /// </summary>
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Email { get; set; }

    }
}