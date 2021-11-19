using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    /// <summary>
    /// نظرات پست ها
    /// </summary>
    public class PostCommentModel : BaseEntityModel
    {
        /// <summary>
        /// PostId
        /// </summary>
        [ForeignKey("Post")]
        [Display(Name = "پست")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int PostId { get; set; }

        /// <summary>
        /// اگر ریپلای باشد این فیلد مقدار می گیرد
        /// </summary>
        [ForeignKey("ParentPostComment")]
        [Display(Name = "کامنت ")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Text { get; set; }

        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ادمین باید هر کامنت را تایید کند
        /// </summary>
        [Display(Name = "مورد تایید است؟")]
        public bool IsAccepted { get; set; }

        //np
        public virtual PostModel Post { get; set; }
        public virtual PostCommentModel ParentPostComment { get; set; }
        public virtual List<PostCommentModel> PostComments { get; set; }
        public virtual ApplicationUserModel User { get; set; }
    }
}