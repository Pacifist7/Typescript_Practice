using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            while (!value)
            { 
                Console.WriteLine("Choose a language from the following selection: English, Spanish, Arabic or French ");
                string language = Console.ReadLine();
                switch (language)
                {
                    case "English":
                        {
                            Console.WriteLine("Hello, world!");
                            break;
                        }
                    case "Spanish":
                        {
                            Console.WriteLine("Hola, mundo!");
                            break;
                        }
                    case "Arabic":
                        {
                            Console.WriteLine("Ahlan, aalam!");
                            break;
                        }
                    case "French":
                        {
                            Console.WriteLine("Bonjour, monde!");
                            break;
                        }
                }
                Console.WriteLine("Would you like to choose another language? Press 'yes' or 'no'.");
                string answer = Console.ReadLine();
                if (answer == "yes")
                { 
                    continue;
                }
                if (answer == "no")
                {
                    Console.WriteLine("Goodbye!.");
                    break;
                }
            }
        }
    }
}
