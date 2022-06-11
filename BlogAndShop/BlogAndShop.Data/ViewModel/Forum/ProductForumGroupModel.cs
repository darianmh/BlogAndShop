using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;

namespace BlogAndShop.Data.ViewModel.Forum
{
    public class ProductForumGroupModel
    {
        /// <summary>
        /// post id
        /// </summary>
        [ForeignKey("Product")]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Data.Product.Product), false)]
        [AdminShowItem(2)]
        [AdminKey]
        public int ProductId { get; set; }

        /// <summary>
        /// tag id
        /// </summary>
        [ForeignKey("ForumTitle")]
        [Display(Name = "انجمن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(ForumTitle), false)]
        [AdminShowItem(1)]
        [AdminKey]
        public int ForumTitleId { get; set; }



        //np
        [Ignore]
        public virtual ProductModel Product { get; set; }
        [Ignore]
        public virtual ForumTitleModel ForumTitle { get; set; }
    }
}