using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    /// برند محصولات
    /// </summary>
    public class BrandModel : BaseEntityModel
    {

        [Display(Name = "نام")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [AdminShowItem(1)]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [TextArea]
        [AdminShowItem(2)]
        public string Description { get; set; }
        [Display(Name = "آدرس سایت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string SiteUrl { get; set; }
        [Display(Name = "لوگو")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [FileUpload]
        public string LogoId { get; set; }

        //np
        [Ignore]
        public virtual List<ProductModel> Products { get; set; }
        public virtual MediaModel Image { get; set; }
    }
}