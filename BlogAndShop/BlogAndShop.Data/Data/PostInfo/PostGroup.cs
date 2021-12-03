using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.PostInfo
{
    /// <summary>
    /// گروه بندی پست ها
    /// </summary>
    public class PostGroup : BaseEntity
    {
        /// <summary>
        /// group title
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// group description
        /// </summary>
        [Display(Name = "توضیحات")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        ///  اگر زیر مجموعه باشد
        /// </summary>
        [ForeignKey("ParentPostGroup")]
        [Display(Name = "سرگروه")]
        [AdminShowItem(3)]
        public int? ParentId { get; set; }


        //np
        [JsonIgnore]
        public virtual List<Post_PostGroup> Post_PostGroups { get; set; }
        [JsonIgnore]
        public virtual List<PostGroup> PostGroups { get; set; }
        [JsonIgnore]
        public virtual PostGroup ParentPostGroup { get; set; }


        public override SelectListItem GetSelectListItem(string selected)
        {
            return new SelectListItem(Title, Id.ToString(), Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase));
        }
    }
}
