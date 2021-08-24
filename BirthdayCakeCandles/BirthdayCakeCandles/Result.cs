using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Result
    {
        static public int birthdayCakeCandles(List<int> arr)
        {
            int[] candles = arr.ToArray();
            int max = candles[0];
            int count = 1;

            for(int i = 1; i < candles.Length; i++)
            {
                if(candles[i] > max)
                {
                    max = candles[i];
                    count = 1;
                }
                else if(candles[i] == max)
                {
                    count++;
                }

            }

            return count;

        }


    }
}
