using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    //Submitted  9 Agust 2021
    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int diagA = 0;
            int diagB = 0;

            /*
            for (int i = 0; i < arr.ToArray().Length; i++)
            {
                diagA += arr[i][0 + i];

                //for (int j = arr.ToArray().Count()- 1; j < arr.Count() ; j--)
                for (int j = arr.ToArray().Length - 1; j < ; j--)
                {
                        diagB += arr[j][j - i];
                }

            }*/

            int leng = arr[0].Count;
            for(int i=0; i < leng; i++)
            {
                diagA += arr[i][i];
                diagB += arr[i][leng - i -1];
            }


            return Math.Abs(diagA - diagB);

        }

    }
}
