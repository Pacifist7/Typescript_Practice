/*Given a number, write a method that returns its cube.
Expected input and output
TheCubeOf(2) → 8
TheCubeOf(-5.5) → -166.375*/

using System;

namespace Basics_Cube
{
    class CubeMethod
    {
        public static double CubeOf(double x)
        {
            return x*x*x;
        }
    
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("The cube of "+ x + " is " + CubeOf(x));
        }
    }
}
