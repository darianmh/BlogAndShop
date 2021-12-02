using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.Classes.Date
{
    public static class DateHelper
    {
        public static string ToPeString(this DateTime dateTime)
        {
            return dateTime.ToLongDateString();
        }
    }
}
