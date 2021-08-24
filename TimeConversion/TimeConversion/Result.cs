using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Result
    {
        public static string timeConversion(string s)
        {
            var amOrPm = s.Substring(8); //19:56:45PM - Read place 8
            var hours = s.Substring(0, 2); //hour - To verify 12 to set it as 12 or 00
            var remainig = s.Substring(2, 6); // Read from place 2, then take 6 places from there

            if(amOrPm == "AM" && hours == "12")
            {
                hours = "00";
            }
            else if (amOrPm == "PM")
            {
                var numericHour = int.Parse(hours);
                if(numericHour != 12)
                {
                    hours = Convert.ToString(12 + numericHour);
                }
            }

            return hours + remainig;

        }



    }
}

/*
bool successfulConversion = DateTime.TryParse(s, out DateTime time);

if(successfulConversion)
{
    return time.ToString("HH:mm:ss");
}
return "hello";
*/
