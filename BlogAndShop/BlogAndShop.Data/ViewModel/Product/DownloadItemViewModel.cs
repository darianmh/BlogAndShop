using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.Product
{
    public class DownloadItemViewModel : BaseEntityModel
    {
        [DbOptionList(typeof(Media), true)]
        [Display(Name = "فایل موجود در سیستم")]
        //[Display(Name = "آدرس")]
        public int DownloadPathId { get; set; }
        [AdminShowItem(1)]
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [TextArea]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [FileUpload()]
        [Display(Name = "تصویر")]
        public int BannerImageId { get; set; }
        [TextArea]
        [Display(Name = "کلمات کلیدی")]
        public string Keywords { get; set; }
        [Ignore]
        public string Extension { get; set; }




        //np
        [JsonIgnore]
        [Ignore]
        public virtual MediaModel DownloadPath { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual MediaModel BannerImage { get; set; }
    }
}