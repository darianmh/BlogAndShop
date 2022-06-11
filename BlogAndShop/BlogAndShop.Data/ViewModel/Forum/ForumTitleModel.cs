using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;
using CommonConfiguration.Core.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.Forum
{
    /// <summary>
    ///   موضوع بحث 
    /// </summary>
    public class ForumTitleModel : BaseEntityModel
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
        [TextArea]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        /// کاربر ایجاد کننده
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "مالک")]
        [Hidden]
        public int OwnerId { get; set; }

        /// <summary>
        ///  کلمات کلیدی متا
        /// </summary>
        [Display(Name = "کلمات کلیدی متا")]
        [TextArea]
        public string Keywords { get; set; }

        /// <summary>
        ///   توضیحات متا سایت
        /// </summary>
        [Display(Name = "توضیحات متا")]
        [TextArea]
        public string MetaDescription { get; set; }

        /// <summary>
        ///  باز، بسته
        /// </summary>
        [Display(Name = "وضعیت")]
        [EnumList(typeof(ForumStatus))]
        public ForumStatus Status { get; set; }
        /// <summary>
        /// کاربر ایجاد کننده
        /// </summary>
        [ForeignKey("ForumGroup")]
        [Display(Name = "گروه")]
        [DbOptionList(typeof(ForumGroup), false)]
        public int ForumGroupId { get; set; }


        //np
        [JsonIgnore]
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual List<ForumCommentModel> ForumComments { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual ForumGroupModel ForumGroup { get; set; }
        [Ignore]
        [JsonIgnore]
        public virtual List<ProductForumGroupModel> ProductForumGroups { get; set; }
    }
}