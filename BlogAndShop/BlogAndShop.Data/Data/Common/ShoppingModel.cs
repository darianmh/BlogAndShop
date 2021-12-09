using System.ComponentModel.DataAnnotations;

namespace BlogAndShop.Data.Data.Common
{
    public enum ShoppingModel
    {
        [Display(Name = "از تماس")]
        Call=1,
        [Display(Name = "از سبد خرید")]
        Cart =2
    }
}