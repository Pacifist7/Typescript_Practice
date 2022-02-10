using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
            int n_people = int.Parse(Console.ReadLine());
            if (n_people <= 6)
            {
                Console.WriteLine("A table for " + n_people + "! Please follow me and take a seat.");
                Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");

                int water_Count = 0;
                int coffee_Count = 0;
                int other_Count = 0;
                for (int i = 1; i <= n_people; i++)
                {

                    Console.WriteLine("Alright, person number " + i + ", water or coffee?");
                    string drink = Console.ReadLine();

                    if (drink == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        water_Count++;
                    }
                    else if (drink == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        coffee_Count++;
                    }
                    else
                    {
                        Console.WriteLine("We don't have that. No drink for you!");
                        other_Count++;
                    }
                }
                /*Console.WriteLine(water_Count);
                Console.WriteLine(coffee_Count);
                Console.WriteLine(other_Count);*/


                Console.WriteLine("Okay, so that's " + coffee_Count + " coffees and " + water_Count + " waters. I'll be right back. Feel free to grab your food!");
                double total_Price = (coffee_Count * 2.00) + (n_people * 9.99);
                Console.WriteLine("Here's your bill! Your total price is $" + total_Price);
            }
            else
            {
                Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");

            }

        }
    }
}
