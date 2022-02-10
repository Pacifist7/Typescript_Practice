/*Three increasing adjacent
Given an array of numbers, write a method that checks if there are three adjacent numbers 
where second is greater by 1 than the first one and third is greater by 1 than the second one.
Expected input and output
ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82 ]) → True
ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4 ]) → False*/

using System;

namespace Loops_Three_increasing_adjacent
{
    class Program
    {
        public static bool ThreeConsecutiveNumbers(int[] Arr)
        {
            bool value = false;
            for (int i =0; i< Arr.Length - 2; i++ )
            {
                if (Arr[i] + 1 == Arr[i+1]  && Arr[i+1] + 1 == Arr[i+2])
                {
                    value = true;
                }         
            }
            return value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ThreeConsecutiveNumbers(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));
        }
    }
}
