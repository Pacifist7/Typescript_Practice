using System;

namespace Basics_IsResultTheSame2
{
    class ResultBool
    {
        
        public static bool IsResultTheSame(double a, double b)
        {
            if (a ==b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
         public static void Main()
        {
            Console.WriteLine(IsResultTheSame(1+5,6-9));
            Console.WriteLine(IsResultTheSame(2*4,5+3));
        }
    }
}
