using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.Common;

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
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// group description
        /// </summary>
        [Display(Name = "توضیحات")]
        [TextArea]
        [AdminShowItem(2)]
        public string Description { get; set; }
        /// <summary>
        ///  اگر زیر مجموعه باشد
        /// </summary>
        [Display(Name = "سرگروه")]
        [DbOptionList(typeof(PostGroup), true)]
        public int? ParentId { get; set; }
        /// <summary>
        /// کلمات کلیدی
        /// </summary>
        [TextArea]
        [Display(Name = "کلمات کلیدی")]
        public string Keywords { get; set; }

        //np
        [Ignore]
        public virtual List<Post_PostGroupModel> Post_PostGroups { get; set; }

    }
}
