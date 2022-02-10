using System;

namespace Lab3_DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            while (!value)
            {

                Console.WriteLine("Welcome to the Dice Roller app! Please enter the number of sides for a pair of dice.");
                var n_sides = int.Parse(Console.ReadLine());
                Console.WriteLine("You chose to roll a pair of dice with " + n_sides + " sides.");
                


                Random rand = new Random();

                var num1 = rand.Next(1, 7);
                Console.WriteLine("After rolling the first dice, you get " + num1);

                var num2 = rand.Next(1, 7);
                Console.WriteLine("After rolling the second dice, you get " + num2);

                if (n_sides == 6)
                {
                    if (num1 == 1 && num2 == 1)
                    {
                        Console.WriteLine("Snake Eyes!");
                    }

                    if (num1 == 6 && num2 == 6)
                    {
                        Console.WriteLine("Box Cars!");
                    }

                    if (num1 == 1 && num2 == 1)
                    {
                        Console.WriteLine("Snake Eyes!");
                    }

                    if (num1 + num2 == 7 || num1 + num2 == 11)
                    {
                        Console.WriteLine("Win!");
                    }
                }

                Console.WriteLine("Would like to roll the dice again, please select 'yes' or 'no'.");
                var answer = Console.ReadLine();

                if (answer == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye, and thanks for playing!");
                    break;
                }
            }

        }

        public

    }
}
