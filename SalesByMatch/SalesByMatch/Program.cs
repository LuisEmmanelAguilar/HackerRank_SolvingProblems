using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesByMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elemts in the list");
            int numberItems = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the list of itmes separated by a blank space");
            List<int> listItems = Console.ReadLine().TrimEnd().Split(' ')
                                  .Select(x => Convert.ToInt32(x)).ToList();

            int total = 0;

            if (numberItems < listItems.Count)
                throw new Exception("The are more items than the number required.");
            else if (numberItems > listItems.Count)
                throw new Exception("The are less items than the number required.");
            else
                total = Result.TotalPairs(listItems);
            
            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
