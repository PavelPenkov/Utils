using System.Security.Cryptography;
using System.Text;

namespace Synapse.Utils {
    public static class Md5 {
        public static string HexDigest(string str) {
            using (var md5 = new MD5CryptoServiceProvider()) {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(str)).ToHexString();
            }
        }
    }
}