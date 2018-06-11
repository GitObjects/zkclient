using System;
using System.Collections.Generic;

namespace ZookeeperClient
{
    public static class Common
    {
        public static bool IsAvailable(this string val)
        {
            return !string.IsNullOrWhiteSpace(val);
        }

        public static bool IsAvailable(this int? val)
        {
            return val != null && val > 0;
        }

        public static bool IsAvailable(this long? val)
        {
            return val != null && val > 0;
        }

        public static bool IsAvailable<T>(this ICollection<T> list)
        {
            return list != null && list.Count > 0;
        }

        public static string ToDate(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }

        public static string ToDate(this DateTime? dt)
        {
            if (dt == null)
            {
                return null;
            }
            return dt.Value.ToString("yyyy-MM-dd");
        }

        public static string ToDate(this DateTime? dt, DateTime defaultDate)
        {
            if (dt == null)
            {
                dt = defaultDate;
            }
            return dt.Value.ToString("yyyy-MM-dd");
        }

        public static string ToTime(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToTime(this DateTime? dt)
        {
            if (dt == null)
            {
                return null;
            }
            return dt.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
