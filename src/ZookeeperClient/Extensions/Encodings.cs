using System.Text;

namespace ZookeeperClient
{
    public static class Encodings
    {
        public static string GetString(this byte[] bytes)
        {
            if (!bytes.IsAvailable())
            {
                return string.Empty;
            }
            return Encoding.UTF8.GetString(bytes);
        }
        public static byte[] GetBytes(this string str)
        {
            if (!str.IsAvailable())
            {
                return new byte[0];
            }
            return Encoding.UTF8.GetBytes(str);
        }

    }
}
