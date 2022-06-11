using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.HomePage
{
    public class HomeBanner : BaseEntity
    {
        /// <summary>
        /// متن html رو عکس
        /// </summary>
        [Display(Name = "متن عکس")]
        [AdminShowItem(1)]
        public string HtmlContent { get; set; }
        /// <summary>
        /// آدرس تصویر بنر
        /// </summary>
        [Display(Name = "تصویر")]
        [AdminShowItem(2)]
        [ForeignKey("Banner")]
        public int BannerId { get; set; }

        /// <summary>
        /// لینک بنر
        /// </summary>
        [Display(Name = "لینک")]
        [AdminShowItem(3)]
        public string Link { get; set; }

        //np
        [JsonIgnore]
        public virtual Media Banner { get; set; }
    }
}
