using System;

namespace NumberAnalyzer_DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            while (!value)
                {
                Console.WriteLine("Choose an integer between 1 and 100");
                int num = int.Parse(Console.ReadLine());

                if (num%2 != 0 && num < 60)
                {
                    Console.WriteLine("This number is odd and less than 60");
                }

                else if (num%2 == 0 && num >= 2 && num <= 24)
                {
                    Console.WriteLine("This number is even and less than 25");
                }

                else if (num%2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine("This number is even and between 26 and 60 inclusive");
                }

                else if (num % 2 == 0 && num > 60)
                {
                    Console.WriteLine("This number is even and greater than 60");
                }

                else if (num % 2 != 0 && num > 60)
                {
                    Console.WriteLine("This number is odd and greater than 60");
                }



                Console.WriteLine("Would you like to restart, please enter yes or y to continue, or enter any other key to exit.");
                string answer = Console.ReadLine();
                
                if (answer == "yes" || answer == "y")
                {
                    continue;
                }
                
                else
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            }
        }
    }
}
