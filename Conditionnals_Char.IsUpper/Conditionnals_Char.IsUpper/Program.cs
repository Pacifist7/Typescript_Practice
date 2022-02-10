/*Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
Expected input and output
IfConsistsOfUppercaseLetters("xyz") → false
IfConsistsOfUppercaseLetters("DOG") → true
IfConsistsOfUppercaseLetters("L9#") → false*/

using System;

namespace Conditionnals_Char.IsUpper
{
    class Program
    {
        public class Demo
        {
            public static void Main()
            {
                bool res;
                Console.WriteLine("Choose a list of characters: ");
                char val = char.Parse(Console.ReadLine());
                Console.WriteLine("Value = " + val);
                res = Char.IsUpper(val);
                Console.WriteLine("Is the value an uppercase letter? = " + res);
            }
        }
    }
}



    /*static void Main(string[] args)
        {
            bool char;
            Char.IsUpper(char H);
        }
    }
}*/
