/*Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) does not exist!
Expected input and output
CtoF(0) → "T = 32F"
CtoF(100) → "T = 212F"
CtoF(-300) → "Temperature below absolute zero!"*/

using System;

namespace Basics_ConvertTemperature
{
    class Program
    {
        public static string ConvertT(double t)
        {
            if (t>-271.15)
            {
                double f = (t - 32)/1.8;
                return $"{f}";
            }
            else
            {
                return "Temperature below absolute zero";
            }
        }
        
        
        
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a temperature in C:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("The temperature is" + ConvertT(a) + "F");
        }
    }
}
