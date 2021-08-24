using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubrrayDivision
{
    class Result
    {

        public static int birthday(List<int> s, int d, int m)
        {
            int total = 0;
            int[] arr = s.ToArray();

            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                if(i + m <= arr.Length)
                {
                    for(int j = 0; j < m; j++)
                    {
                        sum += arr[i + j];
                    }

                    if(sum == d)
                    {
                        total++;
                    }
                }

            }


            return total;
        }
    }
}
