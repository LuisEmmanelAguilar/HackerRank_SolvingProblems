using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Submitted 9 August 2021
namespace PlusMinus
{
    class Result
    {
        public static void plusMinus(List<int> arr)
        {
            double pos = 0;
            double neg = 0;
            double zero = 0;
            int lenghtArr = arr.ToArray().Length;

            foreach(int num in arr)
            {
                if(num > 0)
                {
                    pos++;
                }
                else if(num < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }

            }


            Console.WriteLine(pos / lenghtArr);
            Console.WriteLine(neg / lenghtArr);
            Console.WriteLine(zero / lenghtArr);

        }
    }
}
