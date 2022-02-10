using System;

namespace Practice_Basics_2
{
    class ConvertTemperatureFunction
    {
        public static double ConvertTemperature(double t)

        {
            return (1.8 * t) + 32;
        }
        public static void Main()
        {

                Console.WriteLine("Enter your Temperature in C");
                double t_C = int.Parse(Console.ReadLine());
                if (t_C > -271.15)
                {
                    double t_F = ConvertTemperature(t_C);
                    Console.WriteLine("It is " + t_F + "F");
                }

                else
                {
                    Console.WriteLine("Temperature below absolute zero!");
                }
            
        }
    }
}
        
            /*Celsius to Fahrenheit
Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C(absolute zero) does not exist!
Expected input and output
CtoF(0) → "T = 32F"
CtoF(100) → "T = 212F"
CtoF(-300) → "Temperature below absolute zero!"*/

    

