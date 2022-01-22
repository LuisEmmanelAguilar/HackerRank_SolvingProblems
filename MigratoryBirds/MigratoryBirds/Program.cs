using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type the length of the array");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Type the numbers into the array separated by a blank-space");
            List<int> listBirds = Console.ReadLine().TrimEnd()
                                .Split(' ').ToList()
                                .Select(stemp => Convert.ToInt32(stemp))
                                .ToList();

            int total = ResultMigratoryBirds.maxSightedBird(listBirds);

            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
