using System;

namespace Primitive_types_and_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a ...");
            }

        }

    }
}
