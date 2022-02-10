/*Check brackets sequence
Given a sequence of brackets, write a method that checks if it has the same number of opening 
and closing brackets.
Expected input and output
CheckBracketsSequence("((()))") → true
CheckBracketsSequence("()(())(") → false
CheckBracketsSequence(")") → false*/

using System;

namespace Strings_CheckBracketSentences
{
    class Program
    {
        public static bool CheckBracketsSequence(string input)
        {
            int LeftBracket = 0;
            int RightBracket = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    LeftBracket++;
                }

                if (input[i] == ')')
                {
                    RightBracket++;
                }  // More than 3 pairs
            }
            return (LeftBracket == RightBracket); // Check for equal number of opening and closing
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(CheckBracketsSequence(")"));
        }
    }
}
