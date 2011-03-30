using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Synapse.Utils
{
    public static class DateTimeUtils
    {
        public readonly static long Origin = new DateTime(1970, 1, 1, 0, 0, 0).Ticks;
        
        public static long ToUnix(this DateTime time) {
            return (time.Ticks - Origin)/(10*1000*1000);
        }
    }
}
