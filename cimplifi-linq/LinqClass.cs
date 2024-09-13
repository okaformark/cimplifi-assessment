using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_linq
{
    public class LinqClass
    {
        public int[] Arr { get; set; }
        public LinqClass(int[] A) => Arr = A;

        public int[] Square() => Arr.Select(x => x * x).ToArray();
    }
}
