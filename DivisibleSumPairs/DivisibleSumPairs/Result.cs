using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    internal class Result
    {
        public static int divisibleSumPairs(int n, int k, List<int> list)
        {
            int totalPairs = 0;
            int[] arr = list.ToArray();

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if((arr[i] + arr[j]) % k == 0)
                        totalPairs++;
                }
            }

            return totalPairs;
        }
        
    }
}
