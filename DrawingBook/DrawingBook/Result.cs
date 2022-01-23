using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    internal class Result
    {
        public static int totalTurnPages(int total, int target)
        {
            var turnPages = 0;

            if(target == 1 || total == target)
                return turnPages;
            if (total % 2 != 0 && target == total - 1)
                return turnPages;


            if(total % 2 == 0)
            {
                if(target <= total / 2)
                {
                    // forward
                    turnPages = target / 2;
                }
                else
                {
                    //backwards
                    double d = ((double)(total - target) / 2);
                    turnPages = (int)Math.Ceiling(d);
                }
            }
            else
            {
                if(target == (total / 2) + 1 && total % 4 == 3)
                {
                    turnPages = (total - target) / 2;
                }
                else
                {
                    if(target <= (total / 2) + 1)
                    {
                        // from start
                        turnPages = target / 2;
                    }
                    else
                    {
                        // end to start
                        turnPages = (total - target) / 2;
                    }
                }
            }


            return turnPages;
                
        }

    }
}
