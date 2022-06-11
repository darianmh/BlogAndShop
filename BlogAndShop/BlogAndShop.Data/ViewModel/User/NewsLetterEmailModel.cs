using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.User
{
    /// <summary>
    /// ایمیل های عضو خبرنامه
    /// </summary>
    public class NewsLetterEmailModel : BaseEntityModel
    {

        /// <summary>
        /// Email
        /// </summary>
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Email { get; set; }

    }
}