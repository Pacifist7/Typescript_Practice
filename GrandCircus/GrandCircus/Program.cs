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

public class Calculator
    {
        public int CalcSum(int a, int b)
        {
            var sum = a + b;
            return sum;
        }
    }
  
//String[] titles = new string[3];

            //double[] prices;
            //prices = new double[4];

            int[] intArray = new int[10] { 1, 2, 3, 10, 19, 210, 456, 251, 5, 8 };

            var zeroIndex = intArray[5];

            intArray[5] = 1000;

            Console.WriteLine(intArray[5]);

        }*/





//ARRAYS




//            EXERCISE 31
//Description
//Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
//Prompt the user to enter an index. Display the element in the array at that index.

//var value = true;
//do
//{



//    int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
//    Console.WriteLine("Please enter an index from 0 to 4: ");
//    var input = int.Parse(Console.ReadLine());

//    Console.WriteLine(intArray[input]);

//    Console.WriteLine("Would you like to continue? y/n");
//    var answer = Console.ReadLine();

//    if (answer == "y")
//    {
//        continue;
//    }
//    else
//    {
//        Console.WriteLine("Goodbye!");
//        break;
//    }


//}
//while (value == true);

//            EXERCISE 32
//Description
//Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
//Prompt the user to enter a number. If the number is in the array, display the index at which it is located.


//var value = true;
//do
//{
//    int[] intArray2 = new int[5] { 2, 8, 0, 24, 51 };
//    Console.WriteLine("Please enter a number: ");
//    var input2 = int.Parse(Console.ReadLine());

//    if (intArray2.Contains(input2))
//    {
//        Console.WriteLine(Array.IndexOf(intArray2, input2));
//    }
//    else
//    {
//        Console.WriteLine("That value cannot be found in the array.");
//    }

//    Console.WriteLine("Would you like to continue? y/n");
//    var answer = Console.ReadLine();

//    if (answer == "y")
//    {
//        continue;
//    }
//    else
//    {
//        Console.WriteLine("Goodbye!");
//        break;
//    }
//}
//while (value == true);

//int[] intarray = new int[5] { 2, 8, 0, 24, 51 };

//int sum = 0;
//for (int i = 0; i < intarray.length; i++)
//{
//    //sum = sum + intarray[i]; same as next line
//    sum += intarray[i];
//}

//console.writeline(sum);

//int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
//int sum = 0;
////sum += intArray[i];

//foreach (int i in intArray)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(sum);

//Array.IndexOf()


//string[] stringArray = new string[3] { "Banana", "Orange", "Grapefruit" };

//foreach(string str in stringArray)
//{
//    Console.WriteLine(str);
//}


//int[] intArray = new int[5] { 2, 8, 0, 24, 51 };

//var indexOfElement = Array.IndexOf(intArray, 8);

//Console.WriteLine(indexOfElement);



//int[] intArray = new int[5] { 2, 8, 0, 24, 51 };

//var blah = Array.IndexOf(intArray, 5);

//Array.Clear(intArray, 1, 3);

//Console.WriteLine(string.Join(",", intArray));

//string[] stringArray = new string[3] { "Captain", "Colonel", "Sargeant" };

//Array.Sort(stringArray);

//Console.WriteLine(string.Join(",", stringArray));

//Array.Clear(stringArray);


//EXERCISE 33
//Description
//Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
//Let the user change the array by specifying an index and a replacement number.


//ME AND LONNIE
//Create an array of size 5
//int[] five = new int[5] { 2, 8, 0, 24, 51 };

//bool choice = true;
//do
//{
//    Console.Write("Enter an index of the array: ");
//    int userInput;
//    string usersInput = Console.ReadLine();
//    bool usersResponse = int.TryParse(usersInput, out userInput);

//    //Checks if userinput is in the array
//    bool containsInt = five.Contains(userInput);

//    if (containsInt == true)
//    {
//        Console.WriteLine($"The value at index {userInput} is {five[userInput]}. Would you like to change it? y/n");
//        var answer = Console.ReadLine();

//        if (answer == "y")
//        {
//            //change five[userInput] element in the array
//            Console.WriteLine($"Enter a new value for  {userInput}: ");
//            var newValue = int.Parse(Console.ReadLine());
//            //var zeroIndex = intArray[5];
//            //intArray[5] = 1000;

//            five[userInput] = newValue;
//            Console.WriteLine(five);
//        }
//        else
//        {
//            Console.WriteLine("Goodbye!");
//            break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Please make sure to enter an index between 0 and 4");
//    }





//} while (choice == true);


//EXERCISE 33
//Description
//Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
//Let the user change the array by specifying an index and a replacement number.



//var value = true;
//do
//{
//    int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
//    Console.WriteLine("Please enter an index of the array between 0 and 4: ");
//    var input2 = int.Parse(Console.ReadLine());

//    if (input2 == 0 || input2 == 1 || input2 == 2 || input2 == 3 || input2 == 4)
//    {
//        Console.WriteLine($"The value at index {input2} is {intArray[input2]}");
//        Console.WriteLine("Would you like to change it? y/n");
//        var answer = Console.ReadLine();

//        if (answer == "y")
//        {

//            Console.WriteLine("What new value would like to choose?");
//            var newElement = int.Parse(Console.ReadLine());
//            intArray[input2] = newElement;
//            Console.WriteLine(string.Join(",", intArray));
//        }

//        else
//        {
//            Console.WriteLine("All right then.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("That value cannot be found in the arreay.");
//    }

//    Console.WriteLine("Would you like to continue? y/n");
//    var answer2 = Console.ReadLine();

//    if (answer2 == "y")
//    {
//        continue;
//    }
//    else
//    {
//        Console.WriteLine("Goodbye!");
//        break;
//    }


//}
//while (value == true);


//EXERCISE 34
//    Description
//    Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256.
//    Prompt the user to enter a command, 'half' or 'double'.
//    If the user enters 'half', half all the elements in the array.
//    If the user enters 'double', double all the elements in the array.

//int[] intArray = new int[5] { 16, 32, 64, 128, 256 };

//Console.WriteLine("Would you like to: ");
//Console.WriteLine("1. half all the elements in the array");
//Console.WriteLine("2. double all the elements in the array");
//Console.WriteLine("Please choose '1' or '2'");

//string answer = Console.ReadLine();

//if (answer=="1")
//    {
//        foreach (var element in intArray)
//        {

//        }
//    }



//Wesneday 2/16

//int[] intArray = new int[4] { 1, 2, 55, 72 };

//int[] secondArray = new int[6];

//Array.Copy(intArray, secondArray, 4);

//int[,] twoDimensionalArray = new int[2, 3]
//{
//    {1,2,3},
//    {4,5,6},
//};

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GrandCircus
{
    class Program
    {

        static void Main(string[] args)
        {

            //int[] intArray = new int[3] {1, 2, 3};

            //string[] strArray = new string[3] { "cSharp", "dotNet", "angular" };

            //indexOf

            //Console.WriteLine(Array.IndexOf(intArray, 2));

            // Console.WriteLine(intArray.Contains(4));

            //Data Structures

            //Collections

            //ArrayList

            //var arrayList = new ArrayList();

            //arrayList.Add(5);

            //arrayList.Add(15);

            //arrayList.Add(4.67);

            //int[] intArray = new int[3] {1, 2, 3};

            //Console.WriteLine(arrayList.Count);

            //for (var i =0;  i< arrayList.Count ; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //arrayList.Insert(1, 1000);

            //for (var i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //LISTS

            //List<int> integerList = new List<int>()
            //{
            //    100,
            //    10,
            //    25786
            //};

            //integerList.Add(1000);

            //foreach(var integer in integerList)
            //{
            //    Console.WriteLine(integer);
            //}

            //List<string> stringList = new List<string>();

            //List<double> doubleList = new List<double>();

            //integerList.Add

            //LIST PRACTICE

            //var value = true;
            //Console.WriteLine("Welcome to Meijer online, what would you like to shop today?");
            //var item = Console.ReadLine();
            //List<string> stringList = new List<string>();
            //stringList.Add(item);




            //do
            //{

            //    Console.WriteLine("Would you like to add something to your shopping list? y/n");

            //    var answer2 = Console.ReadLine();

            //    if (answer2 == "y")
            //    {
            //        Console.WriteLine("What item would you like to add?");

            //        var item2 = Console.ReadLine();
            //        stringList.Add(item2);

            //        //stringList.ForEach(x => Console.WriteLine(x));
            //        Console.WriteLine(string.Join(",", stringList));



            //    }

            //    else
            //    {
            //        Console.WriteLine("All right then, goodbye!");
            //        break;
            //    }



            //}

            //while (value);

            //shoppingList.ForEach(x => Console.WriteLine(x))

            var value = true;
            
            do
            {
                string[] nameArray = new string[3] { "Frederick Douglass", "Malcolm X", "John Lewis" };

                string[] homeTownArray = new string[3] { "Maryland", "Nebraska", "atlanta" };

                string[] favoriteFoodArray = new string[3] { "crab cakes", "a Reuben sandwich", "a peach cobbler" };

                Console.WriteLine("Choose a number between 1 and 3 to select a student.");

                var answer = int.Parse(Console.ReadLine());

                var index = answer - 1;

                Console.WriteLine($"The student you selected is {nameArray[index]}.");

                Console.WriteLine("Which category would you like to display?");

                Console.WriteLine("1. Hometown");

                Console.WriteLine("2. Favorite Food");

                var answer2 = int.Parse(Console.ReadLine());

                if (answer2 == 1)
                {
                    Console.WriteLine($"{nameArray[index]} is from {homeTownArray[index]}");
                }
                else if (answer2 == 2)
                {
                    Console.WriteLine($"{nameArray[index]}'s favorite food is {favoriteFoodArray[index]}");
                }
                else
                {
                    Console.WriteLine("That category does not exist. Please try again. Enter '1' for hometown or '2' for favorite food");
                }


                Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n'");

                var answer3 = Console.ReadLine();

                if (answer3 == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks!");
                    break;
                }
            }

            while (value==true);

        }
    }
}

    

