using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;

namespace BlogAndShop.Data.ViewModel.Forum
{
    /// <summary>
    ///  نظرات کاربران در فروم
    /// </summary>
    public class ForumCommentModel : BaseEntityModel
    {
        /// <summary>
        /// کاربر...می تواند خالی باشد
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "کاربر")]
        [Ignore]
        public int? UserId { get; set; }
        /// <summary>
        /// فروم پدر
        /// </summary>
        [ForeignKey("ForumTitle")]
        [Display(Name = "مجمع")]
        [DbOptionList(typeof(ForumTitle), false)]
        public int ForumId { get; set; }

        /// <summary>
        /// متن
        /// </summary>
        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [TextArea]
        public string Text { get; set; }

        /// <summary>
        /// ادمین باید هر کامنت را تایید کند
        /// </summary>
        [Display(Name = "تایید شده؟")]
        public bool IsAccepted { get; set; }


        //np
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
        [Ignore]
        public virtual ForumTitleModel ForumTitle { get; set; }
    }
}