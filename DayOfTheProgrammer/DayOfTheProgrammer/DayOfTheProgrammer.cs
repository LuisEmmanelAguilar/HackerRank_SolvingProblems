using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    internal class DayOfTheProgrammer
    {
        public static string programmerDay(int year)
        {
            if (year < 1918)
                return year % 4 == 0 ? "12.09." + year : "13.09." + year;
            if (year == 1918)
                return "26.09.1918";
            else 
                return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? "12.09." + year : "13.09." + year;  

        }

    }
}
