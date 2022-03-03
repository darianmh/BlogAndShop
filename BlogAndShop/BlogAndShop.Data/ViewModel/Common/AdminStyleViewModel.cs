using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;

namespace BlogAndShop.Data.ViewModel.Common
{
    /// <summary>
    /// صفحه ویرایش استایل در پنل ادمین
    /// </summary>
    public class AdminStyleViewModel
    {
        [TextArea]
        public string Style { get; set; }
    }
}
