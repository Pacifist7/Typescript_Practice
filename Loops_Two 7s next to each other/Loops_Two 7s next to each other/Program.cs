/*Two 7s next to each other
Given an array of positive digits, write a method that returns number of times that 
two 7's are next to each other in an array.
Expected input and output
Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 1
Two7sNextToEachOther([ 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 ]) → 3*/

using System;
using System.Linq;

namespace Loops_Two_7s_next_to_each_other
{
    class Program
    {
        public static int Two7sNextToEachOther(int[] Arr)
        {
            int Adjacent = 0;
            for (int i=0; i<Arr.Length-1; i++)
            {
                if (Arr[i]==7 && Arr[i+1]==7)
                {
                    Adjacent++;
                }
            }
            return Adjacent;
        }
        
        static void Main(string[] args)
        {
            int[] Arr = { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 };
            Console.WriteLine(Two7sNextToEachOther(Arr));
        }
    }
}
