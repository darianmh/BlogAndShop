using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    ///   گروه بندی محصولات 
    /// </summary>
    public class ProductGroupModel : BaseEntityModel
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        [Display(Name = "توضیحات")]
        [HtmlEdit]
        public string Description { get; set; }

        /// <summary>
        ///  اگر زیر مجموعه باشد
        /// </summary>
        [ForeignKey("ParentProductGroup")]
        [Display(Name = "سرگروه")]
        [DbOptionList(typeof(ProductGroup), true)]
        public int? ParentId { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        [Display(Name = "تصویر")]
        [Ignore]
        public string ImageUrl { get; set; }


        //np
        [Ignore]
        public virtual List<ProductModel> Products { get; set; }
        [Ignore]
        public virtual List<ProductGroupModel> ProductGroups { get; set; }
        [Ignore]
        public virtual ProductGroupModel ParentProductGroup { get; set; }
    }
}