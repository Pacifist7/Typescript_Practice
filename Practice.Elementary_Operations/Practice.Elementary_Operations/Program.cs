using System;

namespace Practice.Elementary_Operations
{
    class ElementaryOperationsFunction
    {
        public static string ElementaryOperations(int n1, int n2)
        {
            int addition = n1 + n2;
            int subtraction = n1 - n2;
            int multiplication = n1 * n2;
            double division;

            if (n2 != 0)
            {
                division = n1 / (double)n2;
            }
            else
            {
                division = 0; //Can't divide by 0, but oh well
            }
            return String.Format($"n1+n2={addition}, n1-n2={subtraction}, n1*n2={multiplication}, n1/n2={division}");
        }
        public static void Main()
        {
            Console.WriteLine("Choose your first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose your second number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(ElementaryOperations(n1, n2));
        }
    }
}