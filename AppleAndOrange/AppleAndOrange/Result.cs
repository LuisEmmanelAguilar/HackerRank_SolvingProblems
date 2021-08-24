using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Submitted August 10, 2021
namespace AppleAndOrange
{
    class Result
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int totalApples = 0;
            int totalOranges = 0;
            int[] aApples = apples.ToArray();
            int[] aOranges = oranges.ToArray();

            for(int i = 0; i < aApples.Length; i++)
            {
                if(a + aApples[i] >= s && a + aApples[i] <= t)
                {
                    totalApples++;
                }
            }

            for(int j = 0; j < aOranges.Length; j++)
            {
                if(b + aOranges[j] >= s && b + aOranges[j] <= t)
                {
                    totalOranges++;
                }
            }

            Console.WriteLine("Apples: " + totalApples);
            Console.WriteLine("Oranges: " + totalOranges);

        }
    }
}
/*
 
 Using the information given below, determine the number of apples and oranges that land on Sam’s house.

In the diagram below:

The red region denotes the house, where  is the start point, and  is the endpoint. The apple tree is to the left of the house, 
and the orange tree is to its right.
Assume the trees are located on a single point, where the apple tree is at point , and the orange tree is at point .
When a fruit falls from its tree, it lands  units of distance from its tree of origin along the -axis. *A negative value of  
means the fruit fell  units to the tree’s left, and a positive value of  means it falls  units to the tree’s right. 
Given the value of  for  apples and  oranges, determine how many apples and oranges will fall on Sam’s house (i.e., in the inclusive range )?

Function Description

Complete the countApplesAndOranges function in the editor below. It should print the number of apples and oranges that land on Sam’s house, each on a separate line.

countApplesAndOranges has the following parameter(s):

s: integer, starting point of Sam’s house location.
t: integer, ending location of Sam’s house location.
a: integer, location of the Apple tree.
b: integer, location of the Orange tree.
apples: integer array, distances at which each apple falls from the tree.
oranges: integer array, distances at which each orange falls from the tree.

The first line contains two space-separated integers denoting the respective values of  and .
The second line contains two space-separated integers denoting the respective values of  and .
The third line contains two space-separated integers denoting the respective values of  and .
The fourth line contains  space-separated integers denoting the respective distances that each apple falls from point .
The fifth line contains  space-separated integers denoting the respective distances that each orange falls from point .

Output Format
Print two integers on two different lines:

The first integer: the number of apples that fall on Sam’s house.
The second integer: the number of oranges that fall on Sam’s house.
 */