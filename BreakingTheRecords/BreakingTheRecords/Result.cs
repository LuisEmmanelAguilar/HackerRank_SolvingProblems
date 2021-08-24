using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class Result
    {
        public static List<int> breakingRecords(List<int> arr)
        {
            int[] scores = arr.ToArray();
            int best = 0;
            int worst = 0;
            int max = scores[0];
            int min = scores[0];

            for(int i = 1; i < scores.Length; i++)
            {
                if(scores[i] > max)
                {
                    max = scores[i];
                    best++;
                }
                else if(scores[i] < min)
                {
                    min = scores[i];
                    worst++;
                }
                                
            }

            return new List<int> { best, worst };
        }
    }

}
