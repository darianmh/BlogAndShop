using System;

namespace BlogAndShop.Services.Classes.Date
{
    public static class DateHelper
    {
        public static string ToPeString(this DateTime dateTime)
        {
            return dateTime.ToLongDateString();
        }
    }
}
