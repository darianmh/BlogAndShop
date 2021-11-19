using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.Forum
{
    /// <summary>
    /// دسته بندی انجمن ها
    /// </summary>
    public class ForumGroupModel : BaseEntityModel
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
        [TextArea]
        public string Description { get; set; }

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



        //np
        [JsonIgnore]
        [Ignore]
        public virtual List<ForumTitleModel> ForumTitles { get; set; }
    }
}