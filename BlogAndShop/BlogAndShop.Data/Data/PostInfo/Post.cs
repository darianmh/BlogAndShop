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
    /// پست ها
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// post title
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// Meta Keywords
        /// </summary>
        [Display(Name = "کلمات کلیدی")]
        public string Keywords { get; set; }

        /// <summary>
        /// Meta Description
        /// </summary>
        [Display(Name = "توضیحات")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        /// prefer url for post
        /// </summary>
        [Display(Name = "آدرس صفحه")]
        public string PreferUrl { get; set; }

        /// <summary>
        /// post Content in Html format
        /// </summary>
        [Display(Name = "محتوای HTML")]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Banner Image path
        /// </summary>
        [Display(Name = "تصویر اصلی")]
        public string BannerImage { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public int OwnerId { get; set; }
        [Display(Name = "منتشر شده")]
        public bool IsPublished { get; set; }


        //np
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        [JsonIgnore]
        public virtual List<Post_PostGroup> Post_PostGroups { get; set; }
        [JsonIgnore]
        public virtual List<PostComment> PostComments { get; set; }
        [JsonIgnore]
        public virtual List<Post_Tags> Post_Tags { get; set; }

    }
}