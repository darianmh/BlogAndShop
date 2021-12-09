using System.Collections.Generic;

namespace BlogAndShop.Data.ViewModel.Common
{
    public class AdminShowListViewModel
    {
        public ListPaginationModel AdminListPaginationModel { get; set; }
        /// <summary>
        /// کلید اول آیدی و کلید دوم سایر مقدار ها است
        /// </summary>
        public Dictionary<string, List<string>> Values { get; set; }
        public List<string> Keys { get; set; }
        public string Controller { get; set; }
    }
}