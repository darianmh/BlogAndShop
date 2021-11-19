using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PostInfo
{
    /// <summary>
    /// ارتباط پست و تگ
    ///هر پست می تواند چند تگ داشته باشد
    /// </summary>
    public class Post_Tags
    {
        /// <summary>
        /// post id
        /// </summary>
        [ForeignKey("Post")]
        [Key]
        [Display(Name = "پست")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int PostId { get; set; }

        /// <summary>
        /// tag id
        /// </summary>
        [ForeignKey("User")]
        [Key]
        [Display(Name = "تگ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int TagId { get; set; }



        //np
        [JsonIgnore]
        public virtual Post Post { get; set; }
        [JsonIgnore]
        public virtual Tag Tag { get; set; }
    }
}