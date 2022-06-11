using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonConfiguration.Core.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PostInfo
{
    /// <summary>
    /// ارتباط پست با گروه 
    ///  هر پست می تواند چند گروه داشته باشد
    /// </summary>
    public class Post_PostGroup
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
        /// post group id
        /// </summary>
        [ForeignKey("PostGroup")]
        [Key]
        [Display(Name = "گروه پست")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int GroupId { get; set; }



        //np
        [JsonIgnore]
        public virtual Post Post { get; set; }
        [JsonIgnore]
        public virtual PostGroup PostGroup { get; set; }

    }
}