using System.ComponentModel.DataAnnotations;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.LearningSystem
{
    public class LearningSystemFooterLinkViewModel : BaseEntityModel
    {
        [Display(Name = "متن")]
        [AdminShowItem(1)]
        public string Text { get; set; }
        [Display(Name = "لینک")]
        [AdminShowItem(2)]
        public string Url { get; set; }
    }
}