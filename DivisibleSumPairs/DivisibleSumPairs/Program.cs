using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int n: length of the array
            // int ar[n]: an array of integers
            // int k: the integer divisor

            Console.WriteLine("Type the length of the array");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Type the numbers into the array separated by a blank-space");
            List<int> arN = Console.ReadLine().TrimEnd()
                            .Split(' ').ToList()
                            .Select(stemp => Convert.ToInt32(stemp))
                            .ToList();

            Console.WriteLine("Type integer divisor");
            int k = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.divisibleSumPairs(n, k, arN);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
