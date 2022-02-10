/*The biggest number
Given an array of integers, write a method that returns the biggest number in this array.
Expected input and output
TheBiggestNumber([190, 291, 145, 209, 280, 300]) → 291
TheBiggestNumber([-9, -2, -7, -8, -4]) → -2*/

using System;

namespace Loops_BiggestNumber
{
    class Program
    {
        public static int BiggestNumber(int[] Arr)
        {
            int TheBiggest = Arr[0];
            for (int i=0; i < Arr.Length; i++ )
            {
                if (TheBiggest <Arr[i])
                {
                    TheBiggest = Arr[i];
                }
            }
            return TheBiggest;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BiggestNumber(new int[] {1,3,-2,5,8,-7}));
        }
    }
}
