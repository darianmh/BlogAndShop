using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        [Display(Name = "سرگروه")]
        [AdminShowItem(3)]
        public int? ParentId { get; set; }
        [Display(Name = "کلمات کلیدی")]
        [AdminShowItem(4)]
        public string Keywords { get; set; }


        //np
        [JsonIgnore]
        public virtual List<Post_PostGroup> Post_PostGroups { get; set; }


        public override SelectListItem GetSelectListItem(string selected)
        {
            try
            {
                var array = (JArray)JsonConvert.DeserializeObject(selected ?? "");
                var selectedValues = array?.Select(Convert.ToInt32)?.ToList() ?? new List<int>();
                return new SelectListItem(Title, Id.ToString(), selectedValues.Contains(Id));
            }
            catch (Exception e)
            {
                return base.GetSelectListItem(selected);
            }
        }
    }
}
