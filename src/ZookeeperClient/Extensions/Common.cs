using System;
using System.Collections.Generic;

namespace ZookeeperClient
{
    public static class Common
    {
        public static bool Available(this string val)
        {
            return !string.IsNullOrWhiteSpace(val);
        }

        public static bool Available<T>(this ICollection<T> list)
        {
            return list != null && list.Count > 0;
        }
    }
}