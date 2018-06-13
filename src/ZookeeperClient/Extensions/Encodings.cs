using System.Collections.Generic;
using System.Text;

namespace ZookeeperClient
{
    public static class Encodings
    {
        public static byte[] GetBytes(this string str)
        {
            if (!str.Available())
            {
                return new byte[0];
            }
            return Encoding.UTF8.GetBytes(str);
        }

        public static string GetString(this byte[] bytes)
        {
            if (!bytes.Available())
            {
                return string.Empty;
            }
            return Encoding.UTF8.GetString(bytes);
        }

        public static string GetString(this IEnumerable<byte> bytes)
        {
            if (bytes == null)
            {
                return string.Empty;
            }
            return Encoding.UTF8.GetString(bytes as byte[]);
        }
    }
}