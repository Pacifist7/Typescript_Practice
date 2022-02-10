using System;

namespace Tuesday2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool value = false;
            Console.WriteLine("Hello, World!");
            while (!value)
            {
                
                Console.WriteLine("Would you like to continue?, select 'yes' or 'no'");
               
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Console.WriteLine("Hello, World!");
                    continue;
                }
                
                else if (answer == "no")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                
                else 
                {
                    Console.WriteLine("Please select 'yes' or 'no'");
                    continue;
                }*/

            /*for (var i = 0; i < 20; i++)
                {
                Console.WriteLine(i);
                }*/

            Console.WriteLine("Favorite food? pizza, sushi, chicken?");
            string userInput = Console.ReadLine();
            switch (userInput)
                {
                case "pizza":
                    Console.WriteLine("Great I like pizza.");
                    break;
                case "sushi":
                    Console.WriteLine("sushi yum");
                    break;
                case "chicken":
                    Console.WriteLine("chicken wings delish");
                    break;
                default:
                    Console.WriteLine("what do you need?");
                    break;
            }
            }
        }
    }

