using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.LearningSystem
{
    public class Course : BaseEntity
    {
        /// <summary>
        /// عنوان دوره
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// مبلغ
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// متن توضیح کوتاه
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// توضیح جامع
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// تصویر دوره
        /// </summary>
        [ForeignKey("Image")]
        public int ImageId { get; set; }
        /// <summary>
        /// کد شناسایی سیستم برای وجود چند سایت آموزشی
        /// </summary>
        [ForeignKey("LearningSystem")]
        public int SystemName { get; set; }


        //np
        [JsonIgnore]
        public virtual Media Image { get; set; }
        [JsonIgnore]
        public virtual LearningSiteConfig LearningSystem { get; set; }
        [JsonIgnore]
        public virtual List<CourseRegisterRequest> CourseRegisterRequests{ get; set; }
    }
}