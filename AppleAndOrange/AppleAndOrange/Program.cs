using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            //s first point of distance the house is landed
            // t second point of distance the house is landed
            string[] firstMiltipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int s = Convert.ToInt32(firstMiltipleInput[0]);
            int t = Convert.ToInt32(firstMiltipleInput[1]);

            // a Apple tree location
            // b Orange tree location
            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int a = Convert.ToInt32(secondMultipleInput[0]);
            int b = Convert.ToInt32(secondMultipleInput[1]);

            // m = number of apples
            // n = number of oranges
            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int m = Convert.ToInt32(thirdMultipleInput[0]);
            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(
                applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(
                orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            Result.countApplesAndOranges(s, t, a, b, apples, oranges);

            Console.ReadLine();
        }
    }
}
