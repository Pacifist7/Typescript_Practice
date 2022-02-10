/*
Console.WriteLine("Give me a language");
           var userInput = (Console.ReadLine());
           switch(userInput)
           {
               case "English":
                   Console.WriteLine("Hello");
                   break;

               case "Arabic":
                   Console.WriteLine("Ahlan");
                   break;

               default:
                   Console.WriteLine("I don't know how to say that");
                   break;

var isStillLooping = true;
Console.WriteLine("Give me a number");
var userInput = int.Parse((Console.ReadLine()));
do
{
    Console.WriteLine(userInput);
    userInput++;
    if (userInput < 9)
    { isStillLooping == false; }
}
while (isStillLooping == true);

while (isStillLooping)
{
    Console.WriteLine(userInput);
    userInput++;
    if(userInput>9)
    {
        isStillLooping = false;

for (var i = 0; userInput<9; i++)
{
    Console.WriteLine(userInput);
    userInput++;

//Exercise 10
Console.WriteLine("What is your height in inches?");
var height = int.Parse(Console.ReadLine());


if (height < 54)
{
    var diff = 54 - height;
    Console.WriteLine("Sorry, you cannot ride the Raptor.You need " + diff +  " more inches");

}
else
{
    Console.WriteLine("Great, you can ride the Raptor!");

Exercise 12
Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0.


            for (int i = 9; i>=0 ; i--)
            {
                Console.WriteLine(i);
            }
Exercise 13

            Console.WriteLine("Choose a number: ");
            var number = int.Parse(Console.ReadLine());

            for (int i = number; i>=0 ; i--)
            {
                Console.WriteLine(i);
            }
Exercise 12
//Output all the numbers from 9 to 0.Use a for loop to output all the numbers from 9 to 0.


    for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(i);


            Console.WriteLine("Give me a number: ");
            var userInput =Console.ReadLine();

            int parsedInt;
            var isInt = int.TryParse(userInput, out parsedInt);

            //you handle the exeption here
            if (isInt == true)
            {
                Console.WriteLine(parsedInt);
            }
            else
            {
                Console.WriteLine("That's not an integer.");

            }
EXERCISE 14
            Prompt the user for a number. Use a for loop to output the squares of all the numbers from 1 to that number.

Console.WriteLine("Choose a number: ");
var input = int.Parse(Console.ReadLine());

for (int i = 1; i <= input; i++)
{
    Console.WriteLine(i * i);
}
  Exercise 15
            Prompt the user for a number. Use a for loop to output the cubes of all the numbers from 1 to that number.
            
Console.WriteLine("Choose a number: ");
var input = int.Parse(Console.ReadLine());

for (int i = 1; i <= input; i++)
{
    Console.WriteLine(i * i * i);
    */








using System;

namespace Thursday2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*EXERCISE 16

Use a for loop to output a triangle of asterisks with a height of ten.*/

            for (int i=0; i<=9; i++)
            {
                for (int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }







        }
    }
}





   