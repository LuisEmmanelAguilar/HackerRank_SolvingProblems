using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, give the length of the Book's pages");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What number page would you like to open?");
            int p = Convert.ToInt32(Console.ReadLine());

            int total = Result.totalTurnPages(n, p);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
