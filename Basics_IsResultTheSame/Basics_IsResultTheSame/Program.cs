/*Is result the same
Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.
Expected input and output
IsResultTheSame(2+2, 2*2) → true
IsResultTheSame(9 / 3, 16 - 1) → false*/

using System;

namespace Basics.IsResultTheSame
{
    class IsResultTheSameFunction
    {

        public static bool IsResultTheSame(double a, double b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        { 
            Console.WriteLine("Choose the first number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the second number: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the first operation between 'sum', 'difference', 'product', 'quotient'");
            string o1 = Console.ReadLine();
            if (o1 == "sum")
            {
                double a = n1 + n2;
            }
            else if (o1 == "difference")
            {
                double a = n1 - n2;
            }
            else if (o1 == "product")
            {
                double a = n1 * n2;
            }
            else if (o1 == "quotient")
            {
                double a = n1 / n2;
            }
            else
            {
                Console.WriteLine("Please select the correct operation.");
            }

            Console.WriteLine("Choose the second operation between sum, difference, product, quotient ");
            string o2 = Console.ReadLine();
            if (o2 == "sum")
            {
                double b = n1 + n2;
            }
            else if (o2 == "difference")
            {
                double b = n1 - n2;
            }
            else if (o2 == "product")
            {
                double b = n1 * n2;
            }
            else if (o2 == "quotient")
            {
                double b = n1 / n2;
            }
            else
            {
                Console.WriteLine("Please select the correct operation.");
            }
            Console.WriteLine(IsResultTheSame(a, b));
        }
    }
}