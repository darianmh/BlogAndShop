using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Forum
{
    /// <summary>
    ///  نظرات کاربران در فروم
    /// </summary>
    public class ForumComment : BaseEntity
    {
        /// <summary>
        /// کاربر...می تواند خالی باشد
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "کاربر")]
        [AdminShowItem(2)]
        public int? UserId { get; set; }
        /// <summary>
        /// فروم پدر
        /// </summary>
        [ForeignKey("ForumTitle")]
        [Display(Name = "مجمع")]
        public int ForumId { get; set; }

        /// <summary>
        /// متن
        /// </summary>
        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Text { get; set; }

        /// <summary>
        /// ادمین باید هر کامنت را تایید کند
        /// </summary>
        [Display(Name = "تایید شده؟")]
        [AdminShowItem(3)]
        public bool IsAccepted { get; set; }

        /// <summary>
        /// وضعیت مشاهده این درخواست
        /// </summary>
        [Display(Name = "وضعیت مشاهده")]
        [EnumList(typeof(MessageStatus))]
        public MessageStatus MessageStatus { get; set; }

        //np
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        [JsonIgnore]
        public virtual ForumTitle ForumTitle { get; set; }
    }
}