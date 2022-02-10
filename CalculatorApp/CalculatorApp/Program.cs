using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = true;
            do
            {


                Console.WriteLine("Welcome to the Calculator App");

                Console.WriteLine("Choose the first number: ");
                var num1 = int.Parse(Console.ReadLine());
                
               

                Console.WriteLine("Choose the second number: ");
                
                var num2 = int.Parse(Console.ReadLine());

              

                Console.WriteLine("Choose your operation from the following list: ");
                Console.WriteLine("Type '1' for addition");
                Console.WriteLine("Type '2' for subtraction");
                Console.WriteLine("Type '3' for multiplication");
                Console.WriteLine("Type '4' for division");
                var operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine(Add(num1, num2));
                        break;

                    case 2:
                        Console.WriteLine(Subtract(num1, num2));
                        break;

                    case 3:
                        Console.WriteLine(Multiply(num1, num2));
                        break;

                    case 4:
                        Console.WriteLine(Divide(num1, num2));
                        break;
                }

                Console.WriteLine("Would you like to continue y/n?");
                var answer = Console.ReadLine();
                if (answer=="y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

            }
            while (value==true);

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply (int a, int b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b != 0) 
            {
                return (double)a / (double)b;
            }
            else
            {
                return 0;            
            }
        }
    }
}
