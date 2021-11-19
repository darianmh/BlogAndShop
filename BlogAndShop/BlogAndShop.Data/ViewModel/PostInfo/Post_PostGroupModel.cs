using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    /// <summary>
    /// ارتباط پست با گروه 
    ///  هر پست می تواند چند گروه داشته باشد
    /// </summary>
    public class Post_PostGroupModel
    {
        /// <summary>
        /// post id
        /// </summary>
        [ForeignKey("Post")]
        [Display(Name = "پست")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int PostId { get; set; }

        /// <summary>
        /// post group id
        /// </summary>
        [ForeignKey("PostGroup")]
        [Display(Name = "گروه پست")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int GroupId { get; set; }



        //np
        public virtual PostModel Post { get; set; }
        public virtual PostGroupModel PostGroup { get; set; }

    }
}