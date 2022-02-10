/*   Console.WriteLine("Hi this is the new calculator app!");

            //Ask the user what function they want to do

            //Ask the user how many numbers we're dealing with

            //Get user input

            //Validate user input

            //Based on the function do different math

            Console.WriteLine("Give me the first number you want to add");
            var userInput = Console.ReadLine();
            Console.WriteLine("Give me the second number you want to add");
            var userInput2 = Console.ReadLine();

            var firstNumber = int.Parse(userInput);
            var secondNumber = int.Parse(userInput2);

            Console.WriteLine("Your number is: ");
            Console.WriteLine(firstNumber + secondNumber);
            Console.ReadLine();
 //var userName = calc.AskUserName();

            //Console.WriteLine(userName);
//Instatiate
           /* var calc = new Calculator();

           

            var rand = new Random();


            for (int i =0; i<5; i++)
            {
                var randomNumber = rand.Next(1, 7);
                Console.WriteLine(randomNumber);

            }
        }



        public void NewMethod()
        {

        }

       
    }

    public class Calculator

        public static int staticInteger { get; set; }

    {
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public string AskUserName()
        {
            Console.WriteLine("What's your name?");
            var userInput = Console.ReadLine();
            
            return userInput;
        }*/


using System;

namespace GrandCircus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my calculator app!");
        }
            
    

    }
    public class Calculator
    {
        public int CalcSum(int a, int b)
        {
            var sum = a + b;
            return sum;
        }
    }
}
