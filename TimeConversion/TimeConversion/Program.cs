using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            Console.WriteLine(result);

            Console.ReadLine();
        }

    }
}

/*
    Problem: https://www.hackerrank.com/challenges/time-conversion/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Get the input 12 hour format time string. Let the string be s.
    2. Get the hour component of time by extracting first two characters of string s. Let it be h.
    3. Let the remainig time component after removing h (obtained in step # 2) from s above be r.
    4. If input string s is in AM format and h is equal to "12" then set h = "00".
    5. If input string s is in PM format and h is not equal to "12" then - add 12 to numerical value of h and set it back to h as a string. 
    6. Append r to h and print it on console.
    Time Complexity:  O(1)
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/
