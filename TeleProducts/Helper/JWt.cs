using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleProducts.Helper
{
    public class JWt
    {
        public string key { get; set; }
        public char[] Key { get; internal set; }
        public string issur { get; set; }
        public string Audins { get; set; }
        public double DurationDays { get; set; }

    }
}
