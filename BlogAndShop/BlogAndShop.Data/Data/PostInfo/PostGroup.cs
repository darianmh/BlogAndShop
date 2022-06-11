using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BlogAndShop.Data.Classes;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Utilities;
using CommonConfiguration.Core.Data.ViewModel.Utilities;
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


        public override MySelectListItem GetSelectListItem(string selected)
        {
            try
            {
                var array = (JArray)JsonConvert.DeserializeObject(selected ?? "");
                var selectedValues = array?.Select(Convert.ToInt32)?.ToList() ?? new List<int>();
                return new MySelectListItem(Title, Id.ToString(), selectedValues.Contains(Id));
            }
            catch (Exception e)
            {
                return new MySelectListItem(Title.ToString(), Id.ToString(), selected: Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
