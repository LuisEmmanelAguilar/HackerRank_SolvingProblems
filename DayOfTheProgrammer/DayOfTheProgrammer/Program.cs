using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // leap year is divisible by 4
            // for example 1984 is divisible by 4
            Console.WriteLine("Please enter a year to determine wich date is the Day of the Programmer in the chosen year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year.ToString().Length > 4)
                throw new Exception("The year must be 4 digits");

            string day = DayOfTheProgrammer.programmerDay(year);
            Console.WriteLine(day);
            Console.ReadLine();

        }
    }
}
