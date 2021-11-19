using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int PostId { get; set; }

        /// <summary>
        /// tag id
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "تگ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int TagId { get; set; }



        //np
        public virtual PostModel Post { get; set; }
        public virtual TagModel Tag { get; set; }
    }
}