/*If has neighbour
Given three letter long string, write a method that checks if at least one neighbour of middle letter is its neighbour in the alphabet.
Expected input and output
IsLonelyIsland("XYZ") → True
IsLonelyIsland("GWK") → False*/

using System;

namespace Conditionals_IfHasNeighbor
{
    class Program
    {
        public static bool Neighbor(int i1, int i2, int i3)
        {
            return Math.Abs(i1 - i2) == 1 || Math.Abs(i1-i3) ==1 || Math.Abs(i2-i3)==1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type a three letter string: ");
            string str = Console.ReadLine();
            Char c1 = str[0];
            Char c2 = str[1];
            Char c3 = str[2];

            int i1 = char.ToUpper(c1) - 64;
            int i2 = char.ToUpper(c2) - 64;
            int i3 = char.ToUpper(c3) - 64;

            Console.WriteLine(Neighbor(i1, i2, i3));

            /*Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(i3);*/

        }
    }
}
