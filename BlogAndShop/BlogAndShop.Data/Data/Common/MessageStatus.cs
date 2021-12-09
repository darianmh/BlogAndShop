using System.ComponentModel.DataAnnotations;

namespace BlogAndShop.Data.Data.Common
{
    public enum MessageStatus
    {
        [Display(Name = "جدید")]
        New = 0,
        [Display(Name = "باز شده")]
        Seen = 1,
        [Display(Name = "لغو شده")]
        Canceled = 2,
        [Display(Name = "تمام شده")]
        Done = 3
    }
}