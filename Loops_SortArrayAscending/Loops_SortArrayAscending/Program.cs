/*Sort array ascending
Given an array of integers, write a method that returns sorted array in ascending order.
Expected input and output
SortArrayAscending([9, 5, 7, 2, 1, 8]) →  [1, 2, 5, 7, 8, 9]*/

using System;

namespace Loops_SortArrayAscending
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] list = { 98, 23, 97, 36, 77 };
            Console.WriteLine("Original Unsorted List");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Array.Sort(list);
            Console.WriteLine("\nSorted List");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");

            }
        }
        
    }
}

