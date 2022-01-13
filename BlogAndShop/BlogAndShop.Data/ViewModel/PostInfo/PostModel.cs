using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
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
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// Meta Keywords
        /// </summary>
        [Display(Name = "کلمات کلیدی")]
        [TextArea]
        public string Keywords { get; set; }

        /// <summary>
        /// Meta Description
        /// </summary>
        [Display(Name = "توضیحات")]
        [TextArea]
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
        [HtmlEdit]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Banner Image path
        /// </summary>
        [Display(Name = "تصویر اصلی")]
        [FileUpload]
        public string BannerImage { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [Hidden]
        public int OwnerId { get; set; }


        //added entity
        [DbOptionList(typeof(Tag), true, true)]
        [Display(Name = "تگ ها")]
        public List<int> SelectedTags { get; set; }

        [DbOptionList(typeof(PostGroup), false, true)]
        [Display(Name = "دسته بندی ها")]
        public List<int> SelectedGroups { get; set; }
        [Display(Name = "منتشر شده")]
        [AdminShowItem(3)]
        public bool IsPublished { get; set; }

        [Ignore]
        public bool SaveAndContinue { get; set; }

        //np
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
        [Ignore]
        public virtual List<Post_PostGroupModel> Post_PostGroups { get; set; }
        [Ignore]
        public virtual List<PostCommentModel> PostComments { get; set; }
        [Ignore]
        public virtual List<Post_TagsModel> Post_Tags { get; set; }

        //extra
        [Ignore]
        public List<TagModel> Tags { get; set; }
        [Ignore]
        public List<PostModel> RelatedPosts { get; set; }

        [Ignore]
        public List<CommentModel> CommentsModel { get; set; }
        [Ignore]
        public string MessageText { get; set; }
    }
}