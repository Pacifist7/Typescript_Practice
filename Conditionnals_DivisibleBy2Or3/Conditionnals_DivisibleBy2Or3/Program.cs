/*Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
Expected input and output
DivisibleBy2Or3(15, 30) → 450
DivisibleBy2Or3(2, 90) → 180
DivisibleBy2Or3(7, 12) → 19*/

using System;

namespace Conditionnals_DivisibleBy2Or3
{
    class DivisibleMethod
    {
        public static int Divisible(int a, int b)
        {
            if ((a%2==0 || a%3==0) && (b%2==0 || b%3==0))
            {
                return a * b;
            }
            else
            {
                return a + b;
            }
        }
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Divisible(a, b));

        }
    }
}
