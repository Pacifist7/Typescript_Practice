/*Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
Expected input and output
IfConsistsOfUppercaseLetters("xyz") → false
IfConsistsOfUppercaseLetters("DOG") → true
IfConsistsOfUppercaseLetters("L9#") → false*/

using System;

namespace Conditionnals_String.UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsAllUpper(string input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!Char.IsUpper(input[i]))
                        return false;
                }

                return true;
            }
            Console.WriteLine("Choose a list of characters: ");
            string Character = Console.ReadLine();
            Console.WriteLine(IsAllUpper(Character));
        }
    }
}
