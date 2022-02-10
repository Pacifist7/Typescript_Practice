/*Positive, negative or zero
Given a number, write a method that checks if it is positive, negative or zero.
Expected input and output
PositiveNegativeOrZero(5.24) → positive
PositiveNegativeOrZero(0.0) → zero
PositiveNegativeOrZero(-994.53) → negative*/

using System;

namespace Conditionals_Sign
{
    class Program
    {
        public static string Sign(int x)
        {
            if (x>0)
            { 
                return "positive";
            }
            else if (x<0)
            {
                return "negative";
            }
            else 
            {
                return "zero";
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Sign(x));

        }
    }
}
