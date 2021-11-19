using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    /// <summary>
    /// گروه بندی پست ها
    /// </summary>
    public class PostGroupModel : BaseEntityModel
    {
        /// <summary>
        /// group title
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Title { get; set; }

        /// <summary>
        /// group description
        /// </summary>
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        /// <summary>
        ///  اگر زیر مجموعه باشد
        /// </summary>
        [ForeignKey("ParentPostGroup")]
        [Display(Name = "سرگروه")]
        public int? ParentId { get; set; }

        //np
        public virtual List<Post_PostGroupModel> Post_PostGroups { get; set; }
        public virtual List<PostGroupModel> PostGroups { get; set; }
        public virtual PostGroupModel ParentPostGroup { get; set; }

    }
}
