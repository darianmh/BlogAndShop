using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.PostInfo;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Forum
{
    public class Product_ForumInfo
    {
        /// <summary>
        /// post id
        /// </summary>
        [ForeignKey("Product")]
        [Key]
        [Display(Name = "محصول")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int ProductId { get; set; }

        /// <summary>
        /// tag id
        /// </summary>
        [ForeignKey("ForumTitle")]
        [Key]
        [Display(Name = "انجمن")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int ForumTitleId { get; set; }



        //np
        [Ignore]
        [JsonIgnore]
        public virtual Data.Product.Product Product { get; set; }
        [Ignore]
        [JsonIgnore]
        public virtual ForumTitle ForumTitle { get; set; }
    }
}