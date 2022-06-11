using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;
using CommonConfiguration.Core.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.User;

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
        [DbOptionList(typeof(Post), false)]
        public int PostId { get; set; }

        /// <summary>
        /// اگر ریپلای باشد این فیلد مقدار می گیرد
        /// </summary>
        [Display(Name = "کامنت ")]
        [DbOptionList(typeof(PostComment), true)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [TextArea]
        [AdminShowItem(1)]
        public string Text { get; set; }

        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [Hidden]
        public int OwnerId { get; set; }

        /// <summary>
        /// ادمین باید هر کامنت را تایید کند
        /// </summary>
        [Display(Name = "مورد تایید است؟")]
        [AdminShowItem(2)]
        public bool IsAccepted { get; set; }
        /// <summary>
        /// وضعیت مشاهده این درخواست
        /// </summary>
        [Display(Name = "وضعیت مشاهده")]
        [EnumList(typeof(MessageStatus))]
        [AdminShowItem(3)]
        public MessageStatus MessageStatus { get; set; }

        //np
        [Ignore]
        public virtual PostModel Post { get; set; }
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
    }
}