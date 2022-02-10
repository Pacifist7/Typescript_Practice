using System;

namespace Loops_ReturnEvenNumbers
{
    class Program
    {
        public static string ReturnEvenNumbers()
        {
            string str = string.Empty;
            for (int i = 1; i < 100; i++)
            {
                if (i%2 ==0)
                {
                    str += i + " ";
                }
            }
            return str;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnEvenNumbers());
        }
    }
}
