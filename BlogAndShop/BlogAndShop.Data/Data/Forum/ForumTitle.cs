using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Forum
{
    /// <summary>
    ///   موضوع بحث 
    /// </summary>
    public class ForumTitle : BaseEntity
    {

        /// <summary>
        /// عنوان
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات Html
        /// </summary>
        [Display(Name = "توضیحات")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        /// کاربر ایجاد کننده
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public int OwnerId { get; set; }
        /// <summary>
        /// کاربر ایجاد کننده
        /// </summary>
        [ForeignKey("ForumGroup")]
        [Display(Name = "گروه")]
        public int ForumGroupId { get; set; }

        /// <summary>
        ///  کلمات کلیدی متا
        /// </summary>
        [Display(Name = "کلمات کلیدی متا")]
        public string Keywords { get; set; }

        /// <summary>
        ///   توضیحات متا سایت
        /// </summary>
        [Display(Name = "توضیحات متا")]
        public string MetaDescription { get; set; }

        /// <summary>
        ///  باز، بسته
        /// </summary>
        [Display(Name = "وضعیت")]
        [AdminShowItem(4)]
        public ForumStatus Status { get; set; }


        //np
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        [JsonIgnore]
        public virtual ForumGroup ForumGroup { get; set; }
        [JsonIgnore]
        public virtual List<ForumComment> ForumComments { get; set; }


        public override SelectListItem GetSelectListItem()
        {
            return new SelectListItem(Title, Id.ToString());
        }
    }
}