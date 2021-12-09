using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;

namespace BlogAndShop.Data.ViewModel.Common
{
    public class SocialMediaModel : BaseEntityModel
    {
        /// <summary>
        /// نام
        /// </summary>
        [Display(Name = "نام")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Name { get; set; }
        /// <summary>
        /// آدرس و لینک صفحه در شبکه اجتماعی مدنظر
        /// </summary>
        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(2)]
        public string Address { get; set; }
        /// <summary>
        /// نام کلاس حاوی لوگو
        /// </summary>
        [Display(Name = "کلاس لوگو")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string LogoClass { get; set; }
    }
}