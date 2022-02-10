using System;

namespace Substring_Notation
{
    class Program
    {
        static void Main(string[] args)
        {

            int a; // declare variable without initialization

            OutParamExample(out a);// calling method with out keyword

            Console.Write(a);// accessing out parameter value

         
        }
        public static void OutParamExample(out int x)
        {
            x = 100;
        }
    }
}
