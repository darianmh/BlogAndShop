using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PostInfo
{
    /// <summary>
    /// نظرات پست ها
    /// </summary>
    public class PostComment : BaseEntity
    {
        /// <summary>
        /// PostId
        /// </summary>
        [ForeignKey("Post")]
        [Display(Name = "پست")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
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
        [AdminShowItem(2)]
        public string Text { get; set; }

        /// <summary>
        /// OwnerId
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public int OwnerId { get; set; }

        /// <summary>
        /// ادمین باید هر کامنت را تایید کند
        /// </summary>
        [Display(Name = "مورد تایید است؟")]
        [AdminShowItem(4)]
        public bool IsAccepted { get; set; }

        //np
        [JsonIgnore]
        public virtual Post Post { get; set; }
        [JsonIgnore]
        public virtual PostComment ParentPostComment { get; set; }
        [JsonIgnore]
        public virtual List<PostComment> PostComments { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
    }
}