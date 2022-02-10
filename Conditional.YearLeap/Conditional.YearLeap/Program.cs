/*If year is leap
Given a year as integer, write a method that checks if year is leap.
Expected input and output
IfYearIsLeap(2016) → true
IfYearIsLeap(2018) → false*/

using System;

namespace Conditional.YearLeap
{
    class Program
    {
        public static bool YearLeap(int x)
        {
            return x % 4 == 0;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(YearLeap(year));
        }
    }
}
