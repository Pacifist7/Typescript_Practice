/*Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division.Remember that you can't divide any number by 0!
Expected input and output
ElementaryOperations(3, 8) → 11, -5, 24, 0.375*/

using System;

namespace Practice_Basics_3
{
   

    class ElementaryOperationsTask
    {
       
        public static double ElementaryOperations(double n1, double n2)
        {
            return n1+n2;
        }
        public static void Main()
        {
            Console.WriteLine("Choose the first number:");
            double n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the second number:");
            double n2 = int.Parse(Console.ReadLine());
            double sum = ElementaryOperations(n1,n2);
            Console.WriteLine(sum);

        }
    }
}

