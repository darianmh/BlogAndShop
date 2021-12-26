using System;
using System.Globalization;

namespace BlogAndShop.Services.Classes.Date
{
    public static class DateHelper
    {
        #region Fields


        #endregion
        #region Methods
        public static string ToPeString(this DateTime dateTime)
        {
            PersianCalendar calendar = new PersianCalendar();
            var persianMonth = calendar.GetMonth(dateTime);
            var persianDay = calendar.GetDayOfWeek(dateTime);
            var persianYear = calendar.GetYear(dateTime);
            var monthName = GetMonthName(persianMonth);
            var dayName = GetDayOfWeekName(persianDay);
            return $"{dayName} {calendar.GetDayOfMonth(dateTime)} {monthName} {persianYear}";
        }
        public static string ToSiteMapString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-ddTHH:mm:ss+00:00");
        }

        #endregion
        #region Utilities
        private static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1: return "فررودين";
                case 2: return "ارديبهشت";
                case 3: return "خرداد";
                case 4: return "تير‏";
                case 5: return "مرداد";
                case 6: return "شهريور";
                case 7: return "مهر";
                case 8: return "آبان";
                case 9: return "آذر";
                case 10: return "دي";
                case 11: return "بهمن";
                case 12: return "اسفند";
                default: return "";
            }

        }
        private static string GetDayOfWeekName(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Saturday: return "شنبه";
                case DayOfWeek.Sunday: return "يکشنبه";
                case DayOfWeek.Monday: return "دوشنبه";
                case DayOfWeek.Tuesday: return "سه‏ شنبه";
                case DayOfWeek.Wednesday: return "چهارشنبه";
                case DayOfWeek.Thursday: return "پنجشنبه";
                case DayOfWeek.Friday: return "جمعه";
                default: return "";
            }
        }

        #endregion
        #region Ctor

        #endregion


    }
}
