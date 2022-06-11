using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using CommonConfiguration.Core.Data.Data.Common;

namespace BlogAndShop.Data.Data.Common
{
    public class SocialMedia : BaseEntity
    {
        /// <summary>
        /// نام
        /// </summary>
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Name { get; set; }
        /// <summary>
        /// آدرس و لینک صفحه در شبکه اجتماعی مدنظر
        /// </summary>
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(2)]
        public string Address { get; set; }
        /// <summary>
        /// نام کلاس حاوی لوگو
        /// </summary>
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public string LogoClass { get; set; }
    }
}