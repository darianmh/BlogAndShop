using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;

namespace BlogAndShop.Data.ViewModel.Common
{
    /// <summary>
    /// تنظیمات اصلی سایت
    /// </summary>
    public class SiteConfigModel : BaseEntityModel
    {
        /// <summary>
        /// توضیحات متا سایت
        /// </summary>
        [Display(Name = "توضیحات متا")]
        public string Description { get; set; }

        /// <summary>
        /// عنوان متا سایت
        /// </summary>
        [Display(Name = "عنوان متا")]
        public string Title { get; set; }

        /// <summary>
        /// یک فایل برای بارگزاری همه سایز های لوگو
        /// </summary>
        [Display(Name = "فایل لوگو")]
        public string LogoFile { get; set; }
        /// <summary>
        /// شماره تماس برای مشتریان
        /// </summary>
        [Display(Name = "شماره تماس")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// ایمیل برای تماس مشتریان
        /// </summary>
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        /// <summary>
        /// آدرس فیزیکی
        /// </summary>
        [Display(Name = "آدرس")]
        [TextArea]
        public string Address { get; set; }

        /// <summary>
        /// ایندکس انتخابی
        /// صفر همان حالت انتخابی و یک همان حال بدون هیچی با معرفی
        /// </summary>
        [Display(Name = "ایندکس")]
        [EnumList(typeof(SiteIndex))]
        public SiteIndex SelectIndex { get; set; }
        /// <summary>
        /// حاوی html درباره ما
        /// </summary>
        [Display(Name = "درباه ما")]
        [HtmlEdit]
        public string AboutUs { get; set; }
    }
}