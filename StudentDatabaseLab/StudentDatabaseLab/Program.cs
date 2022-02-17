using System;
using System.Linq;

namespace StudentDatabaseLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = true;

            do
            {
                string[] nameArray = new string[3] { "Frederick Douglass", "Malcolm X", "John Lewis" };

                string[] homeTownArray = new string[3] { "Maryland", "Nebraska", "atlanta" };

                string[] favoriteFoodArray = new string[3] { "crab cakes", "a Reuben sandwich", "a peach cobbler" };

                Console.WriteLine("Choose a number between 1 and 3 to select a student.");

                var answer = int.Parse(Console.ReadLine());

                var index = answer - 1;

                Console.WriteLine($"The student you selected is {nameArray[index]}.");

                Console.WriteLine("Which category would you like to display?");

                Console.WriteLine("1. Hometown");

                Console.WriteLine("2. Favorite Food");

                var answer2 = int.Parse(Console.ReadLine());

                if (answer2 == 1)
                {
                    Console.WriteLine($"{nameArray[index]} is from {homeTownArray[index]}");
                }
                else if (answer2 == 2)
                {
                    Console.WriteLine($"{nameArray[index]}'s favorite food is {favoriteFoodArray[index]}");
                }
                else
                {
                    Console.WriteLine("That category does not exist. Please try again. Enter '1' for hometown or '2' for favorite food");
                }


                Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n'");

                var answer3 = Console.ReadLine();

                if (answer3 == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks!");
                    break;
                }
            }

            while (value == true);
        }
    }
}