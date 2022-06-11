using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.HomePage
{
    public class HomeBannerModel : BaseEntityModel
    {
        /// <summary>
        /// متن html رو عکس
        /// </summary>
        [Display(Name = "متن عکس")]
        [AdminShowItem(1)]
        [HtmlEdit]
        public string HtmlContent { get; set; }
        /// <summary>
        /// آدرس تصویر بنر
        /// </summary>
        [Display(Name = "تصویر")]
        [AdminShowItem(2)]
        [FileUpload]
        public int BannerId { get; set; }
        /// <summary>
        /// لینک بنر
        /// </summary>
        [Display(Name = "لینک")]
        [AdminShowItem(3)]
        public string Link { get; set; }



        //np
        [JsonIgnore]
        [Ignore]
        public virtual MediaModel Banner { get; set; }
    }
}
