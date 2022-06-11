using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    ///  تصویر برای آلبوم محصولات
    /// </summary>
    public class ProductMediaModel
    {
        /// <summary>
        /// MediaId
        /// </summary>
        [ForeignKey("Media")]
        [Display(Name = "مدیا")]
        [DbOptionList(typeof(Media), false)]
        [AdminShowItem(1)]
        [AdminKey]
        public int MediaId { get; set; }

        /// <summary>
        /// ProductId
        /// </summary>
        [ForeignKey("Product")]
        [Display(Name = "محصول")]
        [DbOptionList(typeof(Data.Product.Product), false)]
        [AdminShowItem(2)]
        [AdminKey]
        public int ProductId { get; set; }



        //np
        [Ignore]
        public virtual MediaModel Media { get; set; }
        [Ignore]
        public virtual ProductModel Product { get; set; }
    }
}