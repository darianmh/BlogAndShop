using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Forum
{
    /// <summary>
    /// دسته بندی انجمن ها
    /// </summary>
    public class ForumGroup : BaseEntity
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات Html
        /// </summary>
        [Display(Name = "توضیحات")]
        [AdminShowItem(2)]
        public string Description { get; set; }

        /// <summary>
        ///  کلمات کلیدی متا
        /// </summary>
        [Display(Name = "کلمات کلیدی متا")]
        public string Keywords { get; set; }

        /// <summary>
        ///   توضیحات متا سایت
        /// </summary>
        [Display(Name = "توضیحات متا")]
        public string MetaDescription { get; set; }



        //np
        [JsonIgnore]
        public virtual List<ForumTitle> ForumTitles { get; set; }




        public override MySelectListItem GetSelectListItem(string selected)
        {
            return new MySelectListItem(Title, Id.ToString(), Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase));
        }
    }
}