using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int n_people = int.Parse(Console.ReadLine());

                int s_bread = n_people * 2;
                int ts_peanut = n_people * 2;
                int ts_jelly = n_people * 4;

                Console.WriteLine("You need:");
                Console.WriteLine(s_bread + " slices of bread");
                Console.WriteLine(ts_peanut + " teaspoons of peanut");
                Console.WriteLine(ts_jelly + " teaspoons of jelly");

                decimal total_loavesNeeded = s_bread / 28m;
                decimal total_jarsPBNeeded = ts_peanut / 32m;
                decimal total_jarsJNeeded = ts_jelly / 48m;

                decimal total_loaves = Math.Ceiling(total_loavesNeeded);
                decimal total_jarsPB = Math.Ceiling(total_jarsPBNeeded);
                decimal total_jarsJ = Math.Ceiling(total_jarsJNeeded);


                Console.WriteLine("Which is ...");
                Console.WriteLine(total_loaves + " loaves of bread");
                Console.WriteLine(total_jarsPB + " jars of peanut butter");
                Console.WriteLine(total_jarsJ + " jars of jelly");

                Console.WriteLine("Would you like to restart, please enter 'yes' or 'y' to continue, or enter any other key to exit.");
                string answer = Console.ReadLine();
                    if (answer == "yes" || answer =="y")
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
