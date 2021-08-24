using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Submitted August 12, 2021
namespace BetweenTwoSets
{
    class Result
    {
        public static int getTotal(List<int> arr, List<int> brr)
        {
            int count = 0;
            int[] ar = arr.ToArray();
            int[] br = brr.ToArray();

            // Arrays to Sort
            Array.Sort(ar);
            Array.Sort(br);

            // Min and Max
            int min = ar[0];
            int max = br[br.Length - 1];

            for(int x = min; x <= max; x++)
            {
                if(hasFactors(x, ar) && isFactor(x,br))
                {
                    count++;
                }
            }

            return count;
        }


        // Has Factors
        public static Boolean hasFactors(int num, int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if(num % a[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }


        // Is Factor
        public static Boolean isFactor(int num, int[] a)
        {
            for(int j = 0; j < a.Length; j++)
            {
                if(a[j] % num != 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}

