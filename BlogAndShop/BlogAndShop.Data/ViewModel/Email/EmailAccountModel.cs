using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Email
{
    public partial class EmailAccountModel : BaseEntityModel
    {
        [Display(Name = "ایمیل")]
        [AdminShowItem(1)]
        public string Email { get; set; }
        [Display(Name = "نام نمایشی")]
        public string DisplayName { get; set; }
        [Display(Name = "هاست")]
        [AdminShowItem(2)]
        public string Host { get; set; }
        [Display(Name = "پورت")]
        public int Port { get; set; }
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "رمز")]
        public string Password { get; set; }
        [Display(Name = "ssl")]
        public bool EnableSsl { get; set; }
        public bool UserDefaultCredentials { get; set; }
        public string FriendlyName { get; set; }
        [Display(Name = "پیشفرض")]
        public bool IsDefault { get; set; }
    }
}
