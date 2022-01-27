using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.ViewModel.Common
{
    public class AdminListViewModel<T>
    {
        public AdminListViewModel(bool hasNext, bool hasPre, List<T> items, int page, int count, int pagesCount) : this()
        {
            AdminListPaginationModel = new ListPaginationModel(hasNext, hasPre, page, count, pagesCount);
            Items = items;
        }

        public AdminListViewModel()
        {
            Items = new List<T>();
            ExtraItems = new Dictionary<string, string>();
        }

        public List<T> Items { get; set; }
        public ListPaginationModel AdminListPaginationModel { get; set; }
        public Dictionary<string, string> ExtraItems { get; set; }
    }
}
