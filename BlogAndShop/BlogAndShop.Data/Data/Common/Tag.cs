using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlogAndShop.Data.Data.Common
{
    /// <summary>
    /// تگ برای پست و محصول
    /// </summary>
    public class Tag : BaseEntity
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
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// tag description
        /// </summary>
        [Display(Name = "توضیحات")]
        [AdminShowItem(2)]
        public string Description { get; set; }


        //np
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        [JsonIgnore]
        public virtual List<ProductTag> ProductTags { get; set; }
        [JsonIgnore]
        public virtual List<Post_Tags> Post_Tags { get; set; }


        public override SelectListItem GetSelectListItem(string selected)
        {
            var array = (JArray)JsonConvert.DeserializeObject(selected);
            var selectedValues = array.Select(Convert.ToInt32).ToList();
            return new SelectListItem(Title, Id.ToString(), selectedValues.Contains(Id));
        }
    }
}