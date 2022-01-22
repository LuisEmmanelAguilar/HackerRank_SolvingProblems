using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter the cost of each item separated by a space blank.");
            List<int> listItems = Console.ReadLine().TrimEnd()
                                  .Split(' ').ToList()
                                  .Select(itemTemp => Convert.ToInt32(itemTemp))
                                  .ToList();

            Console.WriteLine("Please enter the number of the item of the bill, that Anna didn't shared with Brian");
            int itemNotShared = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter amount that Brian charged to Anna");
            int chargedAnna = Convert.ToInt32(Console.ReadLine());

            Result.bonAppetit(listItems, chargedAnna, itemNotShared);

            Console.WriteLine();

        }

    }
}
