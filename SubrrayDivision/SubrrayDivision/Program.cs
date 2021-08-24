using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubrrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(
                sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().Trim().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.birthday(s, d, m);


            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
