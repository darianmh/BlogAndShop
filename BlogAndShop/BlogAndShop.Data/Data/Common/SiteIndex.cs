using System.ComponentModel.DataAnnotations;

namespace BlogAndShop.Data.Data.Common
{
    public enum SiteIndex
    {
        [Display(Name = "اصلی")]
        Main = 0,
        [Display(Name = "فقط About")]
        AboutOnly = 1
    }
}