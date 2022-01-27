using System;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.User;

namespace BlogAndShop.Data.ViewModel.Common
{
    /// <summary>
    /// لاگ آیپی و لینک ورودی برای بازدید هر صفحه
    /// </summary>
    public class PageViewLogViewModel : BaseEntityModel
    {
        [AdminShowItem(2)]
        public string IpV4 { get; set; }
        [AdminShowItem(3)]
        public string RefererUrl { get; set; }
        [AdminShowItem(1)]
        public string CurrentPage { get; set; }
        [DbOptionList(typeof(ApplicationUser), true)]
        public int? UserId { get; set; }
        [AdminShowItem(4)]
        public new DateTime CreateDateTime { get; set; }
    }
}