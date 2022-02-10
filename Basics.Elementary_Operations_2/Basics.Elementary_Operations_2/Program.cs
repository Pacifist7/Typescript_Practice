/*Elementary operations
Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division.Remember that you can't divide any number by 0!
Expected input and output
ElementaryOperations(3, 8) → 11, -5, 24, 0.375*/

using System;

namespace Basics.Elementary_Operations_2
{
    class ElementaryOperationsFunction
    {
        public static string ElementaryOperation(int n1, int n2)
        {
            int sum = n1 + n2;
            int difference = n1 - n2;
            int product = n1 * n2;
            double quotient;
            if (n2 != 0)
            {
                quotient = n1 / (double)n2;
            }
            else
            {
                quotient = 0; //We can't divide by 0, but oh well
            }
            return String.Format($"n1 + n2 = {sum}, n1 - n2 = {difference}, n1 * n2 = {product}, n1 / n2 = {quotient}");
        }
        public static void Main()
        {
             Console.WriteLine("Choose the first number: ");
             int n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Choose the second number: ");
             int n2 = int.Parse(Console.ReadLine());
             Console.WriteLine(ElementaryOperation(n1, n2));
        }
    }
}

        
        
        
        
        
        
        

