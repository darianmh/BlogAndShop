using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Forum
{
    /// <summary>
    /// نمایش انجمن های موجود در دسته بندی
    /// </summary>
    public class ForumListViewModel
    {
        public ForumGroupModel CurrentGroup { get; set; }
        public ListPaginationModel ListPaginationModel { get; set; }
        public List<ForumMiniModel> Forums { get; set; }
        public string Keywords { get; set; }
        public string HeaderText { get; set; }
    }
}
