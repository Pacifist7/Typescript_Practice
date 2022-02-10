/*If greater than third one
Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
Expected input and output
IfGreaterThanThirdOne([2, 7, 12]) → true
IfGreaterThanThirdOne([-5, -8, 50]) → false
.
   int[] n = { 20, 30, 23, 4, 5, 2, 41, 8 };
Console.WriteLine((n[0]));*/

using System;

namespace Conditionnals_GreaterThanThirdOne
{
    class Program
    {
        public static bool IfGreaterThird(int[] arr)
        {
            return arr[0] * arr[1] > arr[2] || arr[0] + arr[1] > arr[2];
        }
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the first integer in the array");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the second integer in the array");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the first third in the array");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(IfGreaterThird(new int[] { n1, n2, n3 }));


        }
    }
}
