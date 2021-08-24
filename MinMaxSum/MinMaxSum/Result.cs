using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class Result
    {
        public static void minMaxSum(List<int> arr)
        {
            int[] ar = arr.ToArray();
            Array.Sort(ar);
            long min = ar.Take(4).Sum(item => (long)item);
            long max = ar.Skip(1).Sum(item => (long)item);

            Console.WriteLine($"{min} {max}");
        }
    }
}
