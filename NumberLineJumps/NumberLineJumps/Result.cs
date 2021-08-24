using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Submitted 10 August 2021
namespace NumberLineJumps
{
    class Result
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int jumps = 0;
            while(jumps < 10000)
            {
                if(x1 + jumps * v1 == x2 + jumps * v2)
                {
                    return "YES";
                }
                jumps++;
            }
            return "NO";
        }
    }
}
