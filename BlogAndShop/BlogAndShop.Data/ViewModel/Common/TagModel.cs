using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.User;

namespace BlogAndShop.Data.ViewModel.Common
{
    /// <summary>
    /// تگ برای پست و محصول
    /// </summary>
    public class TagModel : BaseEntityModel
    {
        /// <summary>
        /// who created first
        /// </summary>
        [ForeignKey("User")]
        [Display(Name = "نگارنده")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int OwnerId { get; set; }

        /// <summary>
        /// tag title
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Title { get; set; }

        /// <summary>
        /// tag description
        /// </summary>
        [Display(Name = "توضیحات")]
        public string Description { get; set; }


        //np
        public virtual ApplicationUserModel User { get; set; }
        public virtual List<ProductTagModel> ProductTags { get; set; }
        public virtual List<Post_TagsModel> Post_Tags { get; set; }

    }
}