/*If number is even
Given an integer, write a method that checks if it is even.
Expected input and output
IfNumberIsEven(721) → false
IfNumberIsEven(1248) → true*/

using System;

namespace Conditional.NumberEven
{
    class Program
    {
        public static bool NumberEven (int n)
        {
            return n%2==0;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberEven(n));

        }
    }
}
