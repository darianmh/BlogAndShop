using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    /// <summary>
    ///  تصویر برای آلبوم محصولات
    /// </summary>
    public class ProductMedia
    {
        /// <summary>
        /// MediaId
        /// </summary>
        [ForeignKey("Media")]
        [Key]
        [Display(Name = "مدیا")]
        public int MediaId { get; set; }

        /// <summary>
        /// ProductId
        /// </summary>
        [ForeignKey("Product")]
        [Key]
        [Display(Name = "محصول")]
        public int ProductId { get; set; }



        //np
        [JsonIgnore]
        public virtual Media Media { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}