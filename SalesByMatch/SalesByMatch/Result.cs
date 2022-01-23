using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesByMatch
{
    internal class Result
    {
        public static int TotalPairs(List<int> listItems)
        {
            int[] arr = listItems.ToArray();
            int total = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            total++;
                            arr[j] = 0;
                            break;
                        }
                    }
                }
            }

            return total;

        }
    }
}
