/*Given two integers, write a method that swaps them using temporary variable.
Expected input and output
SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"
SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"*/

using System;

namespace Basics_SwapNumbers
{
    class Program
    {
        static void SwapNum(ref int x, ref int y)
        {

            int tempswap = x;
            x = y;
            y = tempswap;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Value of a and b before sawapping");
            Console.WriteLine("Choose the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("Choose the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("b=" + " " + b);

            SwapNum(ref a, ref b);

            Console.WriteLine("Value of a and b after sawapping");
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
        }

    }
}
