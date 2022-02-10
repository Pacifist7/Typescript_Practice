/*If sorted ascending
Given an array of three integers, write a method that checks if they are sorted in ascending order.
Expected input and output
IfSortedAscending([3, 7, 10])→ true
IfSortedAscending([74, 62, 99])→ false*/
using System;

namespace Consitionals_Sorted.Ascending
{
    class Program
    {
    static bool SortedAscending(int[] arr)
        {
        return arr[0] <= arr[1] && arr[1] <= arr[2];
        }

    static void Main(string[] args)
    {
        Console.WriteLine("Choose a first number");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a second number");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a third number");
        int n3 = int.Parse(Console.ReadLine());
        int[] arr = {n1, n2, n3};

        Console.WriteLine(arr);

        Console.WriteLine(SortedAscending(new int[] arr);

}
    }
}
