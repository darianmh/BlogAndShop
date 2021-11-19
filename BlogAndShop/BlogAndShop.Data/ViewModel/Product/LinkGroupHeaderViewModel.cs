using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    /// مدل برای نمایش در هدر سایت
    /// </summary>
    public class LinkGroupHeaderViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<LinkSubGroupViewModel> SubGroups { get; set; }


        public LinkGroupHeaderViewModel()
        {
            SubGroups = new List<LinkSubGroupViewModel>();
        }
    }
}
