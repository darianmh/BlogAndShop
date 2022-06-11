﻿using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using CommonConfiguration.Core.Data.Data.Common;

namespace BlogAndShop.Data.Data.Common
{
    /// <summary>
    /// تنظیمات اصلی سایت
    /// </summary>
    public class SiteConfig : BaseEntity
    {
        /// <summary>
        /// توضیحات متا سایت
        /// </summary>
        [Display(Name = "توضیحات متا")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        /// عنوان متا سایت
        /// </summary>
        [Display(Name = "عنوان متا")]
        [AdminShowItem(1)]
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
        public string Address { get; set; }
        /// <summary>
        /// ایندکس انتخابی
        /// صفر همان حالت انتخابی و یک همان حال بدون هیچی با معرفی
        /// </summary>
        [Display(Name = "ایندکس")]
        [EnumList(typeof(SiteIndex))]
        public SiteIndex SelectIndex { get; set; }
        /// <summary>
        /// نوع خرید از طریق ثبت درخواست تماس یا از سبد خرید
        /// </summary>
        public ShoppingModel ShoppingModel { get; set; }
        /// <summary>
        /// حاوی html درباره ما
        /// </summary>
        [Display(Name = "درباه ما")]
        [HtmlEdit]
        public string AboutUs { get; set; }
        /// <summary>
        /// کلمات کلیدی
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// آیکون اصلی سایت
        /// </summary>
        public string SiteIcon { get; set; }
        /// <summary>
        /// آیکون اپلی سایت
        /// </summary>
        public string SiteIcon512 { get; set; }
        /// <summary>
        /// لوگو اینماد
        /// </summary>
        [Display(Name = "لوگو اینماد")]
        [FileUpload]
        public string EnamadLogo { get; set; }
        /// <summary>
        /// لوگو ساماندهی
        /// </summary>
        [Display(Name = "لوگو ساماندهی")]
        [FileUpload]
        public string SamandehiLogo { get; set; }
        /// <summary>
        /// آدرس اینماد
        /// </summary>
        [Display(Name = "اینماد")]
        public string EnamadAddress { get; set; }
        /// <summary>
        /// آدرس ساماندهی
        /// </summary>
        [Display(Name = "ساماندهی")]
        public string SamandehiAddress { get; set; }
        /// <summary>
        /// گروه انجمن برای استفاده در محصولات
        /// </summary>
        [Display(Name = "انجمن بررسی محصول")]
        public int? ProductForumGroup { get; set; }
        /// <summary>
        /// ایمیل های ادمین ها
        /// برای ارسال پیام های مهم
        /// </summary>
        public string AdminEmails { get; set; }
        /// <summary>
        /// شماره های ادمین ها
        /// برای ارسال پیام های مهم
        /// </summary>
        [Display(Name = "شماره ادمین (با, جداکنید)")]
        public string AdminPhones { get; set; }
    }
}