using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    /// <summary>
    /// پست ها
    /// </summary>
    public class PostModel : BaseEntityModel
    {
        /// <summary>
        /// post title
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
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
        public int OwnerId { get; set; }


        //np
        public virtual ApplicationUserModel User { get; set; }
        public virtual List<Post_PostGroupModel> Post_PostGroups { get; set; }
        public virtual List<PostCommentModel> PostComments { get; set; }
        public virtual List<Post_TagsModel> Post_Tags { get; set; }

    }
}