using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    /// <summary>
    /// ارتباط پست و تگ
    ///هر پست می تواند چند تگ داشته باشد
    /// </summary>
    public class Post_TagsModel
    {
        /// <summary>
        /// post id
        /// </summary>
        [ForeignKey("Post")]
        [Display(Name = "پست")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Post), false)]
        public int PostId { get; set; }

        /// <summary>
        /// tag id
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "تگ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Tag), false)]
        public int TagId { get; set; }



        //np
        [Ignore]
        public virtual PostModel Post { get; set; }
        [Ignore]
        public virtual TagModel Tag { get; set; }
    }
}