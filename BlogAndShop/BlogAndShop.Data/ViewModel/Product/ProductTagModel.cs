using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    ///  تگ برای محصولات 
    /// </summary>
    public class ProductTagModel
    {

        /// <summary>
        ///  TagId
        /// </summary>
        [ForeignKey("Tag")]
        [Display(Name = "تگ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Tag), false)]
        public int TagId { get; set; }

        /// <summary>
        /// ProductId
        /// </summary>
        [ForeignKey("Product")]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [DbOptionList(typeof(Data.Product.Product), false)]
        public int ProductId { get; set; }



        //np
        [Ignore]
        public virtual TagModel Tag { get; set; }
        [Ignore]
        public virtual ProductModel Product { get; set; }
    }
}