using System;

namespace ConditionalStatements_AbsoluteValue
{
    class Program
    {
        public static double Abs(double x)
        {
            if (x>=0)
            {
                return x;
            }
            else
            {
                return -x;
            }
        }
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("The absolute value of " + x + " is " + Abs(x));

        }
    }
}
