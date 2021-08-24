using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockMiniMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int p = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.sherlockAndMinimax(arr, p, q);

            Console.WriteLine(result);
            Console.Read();

        }
    }
}
/*
 Watson gives Sherlock an array of integers. Given the endpoints of an integer range, for all  in that inclusive range, determine the minimum( abs(arr[i]-M) for all ) ). Once that has been determined for all integers in the range, return the  which generated the maximum of those values. If there are multiple 's that result in that value, return the lowest one.

For example, your array  and your range is from  to  inclusive.

M	|arr[1]-M|	|arr[2]-M|	|arr[3]-M|	|arr[4]-M|	Min
6	   3		   1		   1		   3		 1
7	   4		   2		   0		   2		 0
8	   5		   3		   1		   1		 1
We look at the Min column and see the maximum of those three values is . Two 's result in that answer so we choose the lower value, .

Function Description

Complete the sherlockAndMinimax function in the editor below. It should return an integer as described.

sherlockAndMinimax has the following parameters:
- arr: an array of integers
- p: an integer that represents the lowest value of the range for 
- q: an integer that represents the highest value of the range for 

Input Format

The first line contains an integer , the number of elements in .
The next line contains  space-separated integers .
The third line contains two space-separated integers  and , the inclusive endpoints for the range of .

Constraints




Output Format

Print the value of  on a line.*/