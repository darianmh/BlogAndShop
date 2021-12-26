using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Utilities;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    /// <summary>
    /// برند محصولات
    /// </summary>
    public class Brand : BaseEntity
    {

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Name { get; set; }
        [Display(Name = "لوگو")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(2)]
        public string Logo { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(3)]
        public string Description { get; set; }
        [Display(Name = "آدرس سایت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(4)]
        public string SiteUrl { get; set; }

        //np
        [JsonIgnore]
        public virtual List<Product> Products { get; set; }



        public override MySelectListItem GetSelectListItem(string selected)
        {
            return new MySelectListItem(Name, Id.ToString(), Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase));
        }
    }
}