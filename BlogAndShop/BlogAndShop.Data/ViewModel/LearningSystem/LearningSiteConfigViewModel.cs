using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.LearningSystem
{
    public class LearningSiteConfigViewModel : BaseEntityModel
    {
        /// <summary>
        /// عنوان سایت
        /// </summary>
        [Display(Name = "عنوان")]
        [AdminShowItem(1)]
        public string Title { get; set; }
        /// <summary>
        /// متن معرفی در شروع
        /// </summary>
        [TextArea]
        [Display(Name = "معرفی")]
        public string AboutText { get; set; }
        /// <summary>
        /// متن فوتر
        /// </summary>
        [TextArea]
        [Display(Name = "متن فوتر")]
        public string FooterText { get; set; }
        /// <summary>
        /// عنوان متا
        /// </summary>
        [Display(Name = "عنوان متا")]
        public string MetaTitle { get; set; }
        /// <summary>
        /// توضیحات متا
        /// </summary>
        [Display(Name = "توضیحات متا")]
        public string MetaDescription { get; set; }
        /// <summary>
        /// آیکون
        /// </summary>
        [Display(Name = "آیکون")]
        [ForeignKey("Icon")]
        [FileUpload()]
        public int IconId { get; set; }


        //np
        [JsonIgnore]
        [Ignore]
        public virtual List<CourseViewModel> Courses { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual MediaModel Icon { get; set; }
    }


}
