using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace Synapse.Utils
{
    public static class DicUtils
    {
        public static IDictionary<string, object> ToDictionary(this object o) {
            return o.GetType()
                .GetProperties()
                .ToDictionary(pi => pi.Name, pi => pi.GetValue(o, new object[0]));
        }

        public static string ToQueryString<Tk,Tv>(this IEnumerable<KeyValuePair<Tk,Tv>> dic) {
            return String.Join("&",
                dic.Select(kvp => String.Format("{0}={1}", kvp.Key, HttpUtility.UrlEncode(kvp.Value.ToString()))));
        }
    }
}
