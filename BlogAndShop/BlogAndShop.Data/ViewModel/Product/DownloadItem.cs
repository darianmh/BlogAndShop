using System.ComponentModel;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Product
{
    public class DownloadItemViewModel : BaseEntityModel
    {
        [DbOptionList(typeof(Media), true)]
        [DisplayName("فایل موجود در سیستم")]
        public int? MediaId { get; set; }
        [DisplayName("آدرس")]
        public string DownloadPath { get; set; }
        [AdminShowItem(1)]
        [DisplayName("عنوان")]
        public string Title { get; set; }
        [TextArea]
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [FileUpload()]
        [DisplayName("تصویر")]
        public string BannerImage { get; set; }
        [TextArea]
        [DisplayName("کلمات کلیدی")]
        public string Keywords { get; set; }
    }
}