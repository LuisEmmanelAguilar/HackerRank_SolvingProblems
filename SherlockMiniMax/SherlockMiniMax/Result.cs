using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace SherlockMiniMax
{
    /*
     1. Store all the input five numbers in an array.
    2. Let the highest and lowest number in the array be h and l. Initialize h to 0 and l to greatest possible number (max of
       the data type in the programming language).
    3. Let the sum of all five numbers in the array be s. Initialize s to 0.
    4. Iterate through five elements of array using a loop
       4.1 Let the current number be c.
       4.2 Increment s by c.
       4.3 If c is less than l then set l to c.
       4.4 If c is greater than h then set h to c.
       4.5 Repeat steps 4.1 through 4.4 for all five elements of the array.
    5. Print the outcome of s - h and s - l on the same line on console separated by space.

    Time Complexity:  O(1) //even though there is a for loop in the algorithm but the problem statement says that number of elements will always be fixed at 5. Since the number of input is not variable so complexity will be O(1). Since the number of input elements is fixed at 5 so the same solution can be implemented using few if-else statements also.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/*/
    class Result
    {
        public static int sherlockAndMinimax(List<int> arr, int p, int q)
        {
            int[] a = arr.ToArray();
            Array.Sort(a);
            long maxDist = 0;
            long maxLoc = long.MaxValue;

            if(p <= a[0])
            {
                maxDist = a[0] - p;
                maxLoc = p;
            }

            if(q >= a[])
        }
    }
}
