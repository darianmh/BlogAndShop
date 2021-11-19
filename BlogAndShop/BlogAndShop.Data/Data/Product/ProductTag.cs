using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    /// <summary>
    ///  تگ برای محصولات 
    /// </summary>
    public class ProductTag
    {

        /// <summary>
        ///  TagId
        /// </summary>
        [ForeignKey("Tag")]
        [Key]
        [Display(Name = "تگ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int TagId { get; set; }

        /// <summary>
        /// ProductId
        /// </summary>
        [ForeignKey("Product")]
        [Key]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int ProductId { get; set; }



        //np
        [JsonIgnore]
        public virtual Tag Tag { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}