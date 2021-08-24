using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Result
    {
        public static void staircase(int n)
        {
            for(int i=0; i < n; i++)
            {
                Console.WriteLine(new String('#', i + 1).PadLeft(n,' '));
            }
        }
    }
}
