namespace Synapse.Utils {
    public static class StringUtils {
        public static string ToHexString(this byte[] xs)
        {
            string hexString = "";
            for (int i = 0; i < xs.Length; i++)
            {
                hexString += xs[i].ToString("x2");
            }
            return hexString;
        }
    }
}