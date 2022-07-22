using System;
using System.Globalization;
using System.Linq;

namespace Parsys.WinClient.ApplicationMethods
{
    public static class DateTimeConverter
    {
        public static DateTime? MiladiDateTimeValidation(DateTime? dateTime)
        {
            try
            {
                return dateTime;
            }
            catch
            {
                return null;
            }
        }



        public static string MiladiDateTimeToShamsiString(DateTime? dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            try
            {
                return pc.GetYear((DateTime)dateTime) + "/" + pc.GetMonth((DateTime)dateTime).ToString("00") + "/" + pc.GetDayOfMonth((DateTime)dateTime).ToString("00");
            }
            catch
            {
                return null;
            }
        }




        public static string MiladiDateTimeToMiladiString(DateTime? dateTime)
        {
            try
            {
                return ((DateTime)dateTime).Year + "/" + ((DateTime)dateTime).Month.ToString("00") + "/" + ((DateTime)dateTime).Day.ToString("00");
            }
            catch
            {
                return null;
            }
        }


        public static DateTime? ShamsiStringToMiladiDateTime(string dateString)
        {
            try
            {
                DateTime date = new DateTime(int.Parse(dateString.Split('/')[0]), int.Parse(dateString.Split('/')[1]), int.Parse(dateString.Split('/')[2]), new PersianCalendar());
                return date;
            }
            catch
            {
                return null;
            }

        }

        public static string ShamsiStringToMiladiString(string dateString)
        {
            try
            {
                DateTime date = new DateTime(int.Parse(dateString.Split('/')[0]), int.Parse(dateString.Split('/')[1]), int.Parse(dateString.Split('/')[2]), new PersianCalendar());
                return date.Year + "/" + date.Month.ToString("00") + "/" + date.Day.ToString("00");
            }
            catch
            {
                return null;
            }

        }

        public static string ShamsiStringValidation(string dateString)
        {
            try
            {
                DateTime date = new DateTime(int.Parse(dateString.Split('/')[0]), int.Parse(dateString.Split('/')[1]), int.Parse(dateString.Split('/')[2]), new PersianCalendar());
                return string.Join("/", dateString.Split('/').Select(c => int.Parse(c).ToString("00")));
            }
            catch
            {
                return null;
            }

        }




    }
}
