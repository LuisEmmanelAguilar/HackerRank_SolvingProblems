using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Submitted Agusts 15, 2021
namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = Result.breakingRecords(scores);

            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();
        }
    }
}
