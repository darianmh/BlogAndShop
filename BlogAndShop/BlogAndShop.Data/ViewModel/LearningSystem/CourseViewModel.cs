using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.LearningSystem
{
    public class CourseViewModel : BaseEntityModel
    {
        /// <summary>
        /// عنوان دوره
        /// </summary>
        [Display(Name = "عنوان")]
        [AdminShowItem(1)]
        public string Title { get; set; }
        /// <summary>
        /// مبلغ
        /// </summary>
        [Display(Name = "مبلغ")]
        public decimal Price { get; set; }
        /// <summary>
        /// متن توضیح کوتاه
        /// </summary>
        [TextArea]
        [Display(Name = "توضیح خلاصه")]
        public string ShortDescription { get; set; }
        /// <summary>
        /// توضیح جامع
        /// </summary>
        [HtmlEdit]
        [Display(Name = "توضیح")]
        public string Description { get; set; }
        /// <summary>
        /// تصویر دوره
        /// </summary>
        [ForeignKey("Image")]
        [FileUpload()]
        [Display(Name = "تصویر")]
        public int ImageId { get; set; }
        /// <summary>
        /// کد شناسایی سیستم برای وجود چند سایت آموزشی
        /// </summary>
        [ForeignKey("LearningSystem")]
        [DbOptionList(typeof(LearningSiteConfig), false)]
        [Display(Name = "آموزشگاه")]
        [AdminShowItem(2)]
        public int SystemName { get; set; }


        //np
        [Ignore]
        public virtual MediaModel Image { get; set; }
        [Ignore]
        public virtual LearningSiteConfigViewModel LearningSystem { get; set; }
        [Ignore]
        public virtual List<CourseRegisterRequestViewModel> CourseRegisterRequests { get; set; }
    }
}