using System;

namespace CSharpExercises.Exercises.Basics
{
    class AddAndMultiplyTask
    {
        public static double AddAndMultiply(double n1, double n2, double n3)
        {
            return (n1 + n2) * n3;
        }

        public static void Main()
        {
            Console.WriteLine("Choose the first number:");
            double n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the second number:");
            double n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the third number:");
            double n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your result is: " + AddAndMultiply(n1, n2, n3));

            /*Console.WriteLine(AddAndMultiply(3, 6, 35));        // 315
            Console.WriteLine(AddAndMultiply(-12, 5, 17));      // -119
            Console.WriteLine(AddAndMultiply(-40, 50, 60));     // 600
            Console.WriteLine(AddAndMultiply(1.7, 9.9, 0.01));*/  // 0.116
        }
    }
}

