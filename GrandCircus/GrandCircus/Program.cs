
//////            //Ask the user what function they want to do

//////            //Ask the user how many numbers we're dealing with

//////            //Get user input

//////            //Validate user input

//////            //Based on the function do different math

//////            Console.WriteLine("Give me the first number you want to add");
//////            var userInput = Console.ReadLine();
//////            Console.WriteLine("Give me the second number you want to add");
//////            var userInput2 = Console.ReadLine();

//////            var firstNumber = int.Parse(userInput);
//////            var secondNumber = int.Parse(userInput2);

//////            Console.WriteLine("Your number is: ");
//////            Console.WriteLine(firstNumber + secondNumber);
//////            Console.ReadLine();
////// //var userName = calc.AskUserName();

//////            //Console.WriteLine(userName);
////////Instatiate
//////           /* var calc = new Calculator();



//////            var rand = new Random();


//////            for (int i =0; i<5; i++)
//////            {
//////                var randomNumber = rand.Next(1, 7);
//////                Console.WriteLine(randomNumber);

//////            }
//////        }



//////        public void NewMethod()
//////        {

//////        }


//////    }

//////    public class Calculator

//////        public static int staticInteger { get; set; }

//////    {
//////        public int Add(int firstNum, int secondNum)
//////        {
//////            return firstNum + secondNum;
//////        }

//////        public string AskUserName()
//////        {
//////            Console.WriteLine("What's your name?");
//////            var userInput = Console.ReadLine();

//////            return userInput;

//////public class Calculator
//////    {
//////        public int CalcSum(int a, int b)
//////        {
//////            var sum = a + b;
//////            return sum;
//////        }
//////    }

////////String[] titles = new string[3];

//////            //double[] prices;
//////            //prices = new double[4];

//////            int[] intArray = new int[10] { 1, 2, 3, 10, 19, 210, 456, 251, 5, 8 };

//////            var zeroIndex = intArray[5];

//////            intArray[5] = 1000;

//////            Console.WriteLine(intArray[5]);

//////        }*/





////////ARRAYS




////////            EXERCISE 31
////////Description
////////Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
////////Prompt the user to enter an index. Display the element in the array at that index.

////////var value = true;
////////do
////////{



////////    int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
////////    Console.WriteLine("Please enter an index from 0 to 4: ");
////////    var input = int.Parse(Console.ReadLine());

////////    Console.WriteLine(intArray[input]);

////////    Console.WriteLine("Would you like to continue? y/n");
////////    var answer = Console.ReadLine();

////////    if (answer == "y")
////////    {
////////        continue;
////////    }
////////    else
////////    {
////////        Console.WriteLine("Goodbye!");
////////        break;
////////    }


////////}
////////while (value == true);

////////            EXERCISE 32
////////Description
////////Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
////////Prompt the user to enter a number. If the number is in the array, display the index at which it is located.


////////var value = true;
////////do
////////{
////////    int[] intArray2 = new int[5] { 2, 8, 0, 24, 51 };
////////    Console.WriteLine("Please enter a number: ");
////////    var input2 = int.Parse(Console.ReadLine());

////////    if (intArray2.Contains(input2))
////////    {
////////        Console.WriteLine(Array.IndexOf(intArray2, input2));
////////    }
////////    else
////////    {
////////        Console.WriteLine("That value cannot be found in the array.");
////////    }

////////    Console.WriteLine("Would you like to continue? y/n");
////////    var answer = Console.ReadLine();

////////    if (answer == "y")
////////    {
////////        continue;
////////    }
////////    else
////////    {
////////        Console.WriteLine("Goodbye!");
////////        break;
////////    }
////////}
////////while (value == true);

////////int[] intarray = new int[5] { 2, 8, 0, 24, 51 };

////////int sum = 0;
////////for (int i = 0; i < intarray.length; i++)
////////{
////////    //sum = sum + intarray[i]; same as next line
////////    sum += intarray[i];
////////}

////////console.writeline(sum);

////////int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
////////int sum = 0;
//////////sum += intArray[i];

////////foreach (int i in intArray)
////////{
////////    Console.WriteLine(i);
////////}
////////Console.WriteLine(sum);

////////Array.IndexOf()


////////string[] stringArray = new string[3] { "Banana", "Orange", "Grapefruit" };

////////foreach(string str in stringArray)
////////{
////////    Console.WriteLine(str);
////////}


////////int[] intArray = new int[5] { 2, 8, 0, 24, 51 };

////////var indexOfElement = Array.IndexOf(intArray, 8);

////////Console.WriteLine(indexOfElement);



////////int[] intArray = new int[5] { 2, 8, 0, 24, 51 };

////////var blah = Array.IndexOf(intArray, 5);

////////Array.Clear(intArray, 1, 3);

////////Console.WriteLine(string.Join(",", intArray));

////////string[] stringArray = new string[3] { "Captain", "Colonel", "Sargeant" };

////////Array.Sort(stringArray);

////////Console.WriteLine(string.Join(",", stringArray));

////////Array.Clear(stringArray);


////////EXERCISE 33
////////Description
////////Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
////////Let the user change the array by specifying an index and a replacement number.


////////ME AND LONNIE
////////Create an array of size 5
////////int[] five = new int[5] { 2, 8, 0, 24, 51 };

////////bool choice = true;
////////do
////////{
////////    Console.Write("Enter an index of the array: ");
////////    int userInput;
////////    string usersInput = Console.ReadLine();
////////    bool usersResponse = int.TryParse(usersInput, out userInput);

////////    //Checks if userinput is in the array
////////    bool containsInt = five.Contains(userInput);

////////    if (containsInt == true)
////////    {
////////        Console.WriteLine($"The value at index {userInput} is {five[userInput]}. Would you like to change it? y/n");
////////        var answer = Console.ReadLine();

////////        if (answer == "y")
////////        {
////////            //change five[userInput] element in the array
////////            Console.WriteLine($"Enter a new value for  {userInput}: ");
////////            var newValue = int.Parse(Console.ReadLine());
////////            //var zeroIndex = intArray[5];
////////            //intArray[5] = 1000;

////////            five[userInput] = newValue;
////////            Console.WriteLine(five);
////////        }
////////        else
////////        {
////////            Console.WriteLine("Goodbye!");
////////            break;
////////        }
////////    }
////////    else
////////    {
////////        Console.WriteLine("Please make sure to enter an index between 0 and 4");
////////    }





////////} while (choice == true);


////////EXERCISE 33
////////Description
////////Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
////////Let the user change the array by specifying an index and a replacement number.



////////var value = true;
////////do
////////{
////////    int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
////////    Console.WriteLine("Please enter an index of the array between 0 and 4: ");
////////    var input2 = int.Parse(Console.ReadLine());

////////    if (input2 == 0 || input2 == 1 || input2 == 2 || input2 == 3 || input2 == 4)
////////    {
////////        Console.WriteLine($"The value at index {input2} is {intArray[input2]}");
////////        Console.WriteLine("Would you like to change it? y/n");
////////        var answer = Console.ReadLine();

////////        if (answer == "y")
////////        {

////////            Console.WriteLine("What new value would like to choose?");
////////            var newElement = int.Parse(Console.ReadLine());
////////            intArray[input2] = newElement;
////////            Console.WriteLine(string.Join(",", intArray));
////////        }

////////        else
////////        {
////////            Console.WriteLine("All right then.");
////////        }
////////    }
////////    else
////////    {
////////        Console.WriteLine("That value cannot be found in the arreay.");
////////    }

////////    Console.WriteLine("Would you like to continue? y/n");
////////    var answer2 = Console.ReadLine();

////////    if (answer2 == "y")
////////    {
////////        continue;
////////    }
////////    else
////////    {
////////        Console.WriteLine("Goodbye!");
////////        break;
////////    }


////////}
////////while (value == true);


////////EXERCISE 34
////////    Description
////////    Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256.
////////    Prompt the user to enter a command, 'half' or 'double'.
////////    If the user enters 'half', half all the elements in the array.
////////    If the user enters 'double', double all the elements in the array.

////////int[] intArray = new int[5] { 16, 32, 64, 128, 256 };

////////Console.WriteLine("Would you like to: ");
////////Console.WriteLine("1. half all the elements in the array");
////////Console.WriteLine("2. double all the elements in the array");
////////Console.WriteLine("Please choose '1' or '2'");

////////string answer = Console.ReadLine();

////////if (answer=="1")
////////    {
////////        foreach (var element in intArray)
////////        {

////////        }
////////    }



////////Wesneday 2/16

////////int[] intArray = new int[4] { 1, 2, 55, 72 };

////////int[] secondArray = new int[6];

////////Array.Copy(intArray, secondArray, 4);

////////int[,] twoDimensionalArray = new int[2, 3]
////////{
////////    {1,2,3},
////////    {4,5,6},
////////};


////////class Program
////////{
////////    private static bool topOfTheStack;

////////    static void Main(string[] args)
////////    {

////////int[] intArray = new int[3] {1, 2, 3};

////////string[] strArray = new string[3] { "cSharp", "dotNet", "angular" };

////////indexOf

////////Console.WriteLine(Array.IndexOf(intArray, 2));

//////// Console.WriteLine(intArray.Contains(4));

////////Data Structures

////////Collections

////////ArrayList

////////var arrayList = new ArrayList();

////////arrayList.Add(5);

////////arrayList.Add(15);

////////arrayList.Add(4.67);

////////int[] intArray = new int[3] {1, 2, 3};

////////Console.WriteLine(arrayList.Count);

////////for (var i =0;  i< arrayList.Count ; i++)
////////{
////////    Console.WriteLine(arrayList[i]);
////////}

////////arrayList.Insert(1, 1000);

////////for (var i = 0; i < arrayList.Count; i++)
////////{
////////    Console.WriteLine(arrayList[i]);
////////}

////////LISTS

////////List<int> integerList = new List<int>()
////////{
////////    100,
////////    10,
////////    25786
////////};

////////integerList.Add(1000);

////////foreach(var integer in integerList)
////////{
////////    Console.WriteLine(integer);
////////}

////////List<string> stringList = new List<string>();

////////List<double> doubleList = new List<double>();

////////integerList.Add

////////LIST PRACTICE

////////var value = true;
////////Console.WriteLine("Welcome to Meijer online, what would you like to shop today?");
////////var item = Console.ReadLine();
////////List<string> stringList = new List<string>();
////////stringList.Add(item);




////////do
////////{

////////    Console.WriteLine("Would you like to add something to your shopping list? y/n");

////////    var answer2 = Console.ReadLine();

////////    if (answer2 == "y")
////////    {
////////        Console.WriteLine("What item would you like to add?");

////////        var item2 = Console.ReadLine();
////////        stringList.Add(item2);

////////        //stringList.ForEach(x => Console.WriteLine(x));
////////        Console.WriteLine(string.Join(",", stringList));



////////    }

////////    else
////////    {
////////        Console.WriteLine("All right then, goodbye!");
////////        break;
////////    }



////////}

////////while (value);

////////shoppingList.ForEach(x => Console.WriteLine(x))

////////var value = true;

////////do
////////{
////////    string[] nameArray = new string[3] { "Frederick Douglass", "Malcolm X", "John Lewis" };

////////    string[] homeTownArray = new string[3] { "Maryland", "Nebraska", "atlanta" };

////////    string[] favoriteFoodArray = new string[3] { "crab cakes", "a Reuben sandwich", "a peach cobbler" };

////////    Console.WriteLine("Choose a number between 1 and 3 to select a student.");

////////    var answer = int.Parse(Console.ReadLine());

////////    var index = answer - 1;

////////    Console.WriteLine($"The student you selected is {nameArray[index]}.");

////////    Console.WriteLine("Which category would you like to display?");

////////    Console.WriteLine("1. Hometown");

////////    Console.WriteLine("2. Favorite Food");

////////    var answer2 = int.Parse(Console.ReadLine());

////////    if (answer2 == 1)
////////    {
////////        Console.WriteLine($"{nameArray[index]} is from {homeTownArray[index]}");
////////    }
////////    else if (answer2 == 2)
////////    {
////////        Console.WriteLine($"{nameArray[index]}'s favorite food is {favoriteFoodArray[index]}");
////////    }
////////    else
////////    {
////////        Console.WriteLine("That category does not exist. Please try again. Enter '1' for hometown or '2' for favorite food");
////////    }


////////    Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n'");

////////    var answer3 = Console.ReadLine();

////////    if (answer3 == "y")
////////    {
////////        continue;
////////    }
////////    else
////////    {
////////        Console.WriteLine("Thanks!");
////////        break;
////////    }
////////}

////////while (value==true);



////////Monday 2/21

////////Stacks (Cafeteria trays)

////////var websiteStack = new Stack<string>();

////////websiteStack.Push("www.google.com");

////////websiteStack.Push("www.bored.com");

////////websiteStack.Push("www.nationalgeographic.com");

////////object topOfTheStack = websiteStack.Peek();

////////Console.WriteLine(topOfTheStack);

////////websiteStack.Pop();

////////topOfTheStack = websiteStack.Peek();

////////Console.WriteLine(topOfTheStack);

//////////Queues

////////var queue = new Queue<string>();

////////queue.Enqueue("Robert");
////////queue.Enqueue("Dave");
////////queue.Enqueue("Angelina");
////////queue.Enqueue("George");

//////////Queues aso have a peak method

////////var queueString = queue.Peek();

////////Console.WriteLine(queueString);

////////queue.Dequeue();

////////queueString = queue.Peek();

////////Console.WriteLine(queueString);

////////LINQ

////////var intList = new List<int>()
////////{
////////    8,
////////    65,
////////    654,
////////    87,
////////    16514,
////////    9,
////////    6514,
////////    84,
////////    78,
////////    49
////////};

//////////this gives ALL the elements that fit the criterion
////////var greaterThanFifty = intList.Where(x => x > 500 && x<15000).ToList();

////////Console.WriteLine(string.Join(",", greaterThanFifty));

////////Console.WriteLine(intList.Count());

////////var oddNumbers = intList.Count(x => x% 2 == 1);

////////Console.WriteLine(oddNumbers);

////////var nameList = new List<string>()
////////{
////////    "Bob",
////////    "Hamid",
////////    "Tyrone",
////////    "Jose",
////////    "Lee",
////////    "Chad"
////////};

//////////var findJose = nameList.Where(x => x == "Jose").First();

////////var findJose = nameList.Where(x => x.Contains("ee")).First();


////////Console.WriteLine(findJose);



////////Shopping List Lab El &Jay LAB

////////var error = "I'm sorry, that's not a valid input";
////////  var repeat = true;

////////  Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
////////  {
////////      {"cake", 5.99m },
////////      {"peanut butter", 3 },
////////      {"jam", 2.98m },
////////      {"banana" , .16m },
////////      {"apple" , .20m },
////////      {"grape juice", 2.35m },
////////      {"bread", 2.89m },
////////      {"eggs", 2.19m },
////////      {"milk", 2 },
////////      {"vodka" , 19.99m },
////////      {"beer", 6.89m }
////////  };

////////  List<string> shoppingList = new List<string>();
////////  List<decimal> shoppingPrice = new List<decimal>();

////////  Console.WriteLine("Welcome to LJ's Groceries");

////////  while (repeat)
////////  {
////////      Console.WriteLine(
////////          $"\nItem                 Price" +
////////          $"\n==============================================" +
////////          $"\nCake                 ${menu["cake"]}" +
////////          $"\nPeanut Butter        ${menu["peanut butter"]}" +
////////          $"\nJam                  ${menu["jam"]}" +
////////          $"\nBanana               ${menu["banana"]}" +
////////          $"\nApple                ${menu["apple"]}" +
////////          $"\nGrape Juice          ${menu["grape juice"]}" +
////////          $"\nBread                ${menu["bread"]}" +
////////          $"\nEggs                 ${menu["eggs"]}" +
////////          $"\nMilk                 ${menu["milk"]}" +
////////          $"\nVodka                ${menu["vodka"]}" +
////////          $"\nBeer                 ${menu["beer"]}");



////////      Console.WriteLine("What item would you like to add to your cart?");
////////      var itemInput = Console.ReadLine().ToLower();

////////      bool isItThere = menu.ContainsKey(itemInput);

////////      if (isItThere)
////////      {
////////          Console.WriteLine($"{itemInput} has been added to your cart for ${menu[itemInput]}");
////////          shoppingList.Add(itemInput);
////////          shoppingPrice.Add(menu[itemInput]);
////////      }

////////      else
////////          Console.WriteLine(error);

////////      Console.WriteLine("Would you like to add another item? (y/n)");
////////      var yn = Console.ReadLine().ToLower();

////////      if (yn == "n")
////////      {
////////          Console.WriteLine("Thank you for shopping with us!\nHere is what you're getting:");


////////          foreach (string item in shoppingList)
////////              Console.WriteLine($"{item} for ${menu[item]}");

////////          var total = shoppingPrice.Sum();

////////          Console.WriteLine($"Your total is ${total}.");
////////          Console.WriteLine("Have a nice day!!!");

////////          repeat = false;
////////      }
////////  }


////////WEDNESDAY 2/23
////////ERRORS


////////var divide = 10 / NotFiniteNumberException;

////////var continueLoop = true;
////////do
////////{
////////    Console.WriteLine("Welcome to ...");
////////    Console.WriteLine("Give me a number");
////////    var userInput = Console.ReadLine();

////////    try
////////    {

////////        //put all the code that could have a runtime error in here
////////        int number = int.Parse(userInput);

////////        var outputNumber = 10 / number;

////////        Console.WriteLine("10 divided by " + number + "is" + outputNumber);

////////    }
////////    catch (DivideByZeroException ex)
////////    {
////////        Console.WriteLine(ex.Message);
////////        Console.WriteLine("Sorry cannot divide by 0");
////////        continue;
////////    }
////////    catch (FormatException ex)
////////    {
////////        Console.WriteLine("Please make sure to choose an integer");
////////    }
////////    finally
////////    {
////////        //Whatever happens, this code runs
////////        //you do NOT need a finally
////////    }
////////}
////////while (continueLoop);

////////THURSDAY 2/24

////////try
////////{

////////}
////////catch
////////{

////////}
////////catch
////////{

////////}

////////CLASSES

////////Class=Classification


////////Student f = new Student("John",20);

//////////Console.WriteLine(f.Name);
//////////Console.WriteLine(f.Age);

//////////Student f2 = new Student("Melissa", 25);

////////var circle = new Circles(5);

////////Console.WriteLine(circle.GetCircumference());

////////var x = 30;

////////Console.WriteLine

////////EXERCISE 42

////////Console.WriteLine("Please choose an x coodinate");
////////var x = int.Parse(Console.ReadLine());

////////Console.WriteLine("Please choose a y coodinate");
////////var y = int.Parse(Console.ReadLine());

//////////Instantiate
////////var point = new Point(x, y);


////////Console.WriteLine(point.FindCoordinates());


//////////EXERCISE 43

////////Console.WriteLine($"The distance from the point you created to the origin is " + point.CalculateDistance());


////////Exercise 44
////////Point p1 = new Point(5, 10);

////////Point p2 = new Point(2, 3);

////////var midpoint = p1.CalculateMidpoint(p2);

////////Console.WriteLine(midpoint.X);
////////Console.WriteLine(midpoint.Y);



////////Console.WriteLine("Please enter a side length");

////////var s = int.Parse(Console.ReadLine());

////////Square s1 = new Square(s);

////////Console.WriteLine($"The perimeter of your square is " + s1.CalculatePerimeter() + " and the area of your square is " + s1.CalculateArea());



//////using GrandCircus;
//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;


////////Exercise 43    

////////Triangle triangle1 = new Triangle(1, 2, 3);

//////    Triangle triangle1 = new Triangle(1,2,3);

//////Console.WriteLine(triangle1.CalculatePerimeter());

//////Console.WriteLine(triangle1.CalculateArea());


////using System;
////using System.Collections.Generic;
///////*   Console.WriteLine("Hi this is the new calculator app!");
///////

//////Monday 3/7/2022

//////Question 1

////static int AddStarWarsCharacters(string[] input)
////{
////    return Array.IndexOf(input, "Yoda");
////}


//////Question 2

////static void DeathStarCombat(Dictionary<string, int> greatJedi)
////{

////}

////Dictionary<string, int> deathStarCharacters = new Dictionary<string, int>();
////deathStarCharacters.Add("Yoda", 50);
////deathStarCharacters.Add("Obi Wan", 35);
////deathStarCharacters.Add("Anosha", 40);


////WEDNESDAY 3/9
////ENUM = Set Amount of Data

//using GrandCircus;
//using System;
//using System.Collections.Generic;
//using System.IO;



////DaysOfWeek weekDay1 = DaysOfWeek.Monday;

//////Console.WriteLine(weekDay1);

//////Console.WriteLine("Please pick...");

//////Console.WriteLine("Horror, ... Comedy");

////List<Movies> movieDatabase = new List<Movies>();


////string userinput = Console.ReadLine();

////MovieCategory parsedMovieCategory;

////bool isEnumValue = Enum.TryParse(userinput, out parsedMovieCategory);

////switch (parsedMovieCategory)
////{
////    case MovieCategory.Comedy:
////        //do some logic here
////        break;

////    case MovieCategory.Horror:
////        //do other logic
////        break;
////        //...
////}



//////Console.WriteLine(isEnumValue);
//////Console.WriteLine(parsedMovieCategory);

//////int enumValue = (int)MovieCategory.SciFi;

//////Console.WriteLine(enumValue);


////foreach (MovieCategory category in Enum.GetValues(typeof(MovieCategory)))
////{
////    Console.WriteLine(category);
////}

////foreach (string name in Enum.GetNames(typeof(MovieCategory)))
////{
////    Console.WriteLine(name);
////}

//////Compare Enums

////var firstChoice = MovieCategory.Horror;
////var secondChoice = MovieCategory.Comedy;

////if (firstChoice == secondChoice)
////{

////}

////Exercise 57


//var value = true;

//do
//{
//    Console.WriteLine("Player 1, enter rock (r), paper (p), or scissors(s)");
//    Game parsedGame1;
//    var input1 = Console.ReadLine();
//    bool isEnumValue1 = Enum.TryParse(input1, out parsedGame1);
//    if (isEnumValue1 == false)
//    {
//        Console.WriteLine("Error");
//        break;
//    }


//    Console.WriteLine("Player 2, enter rock (r), paper (p), or scissors(s)");
//    Game parsedGame2;
//    var input2 = Console.ReadLine();
//    bool isEnumValue2 = Enum.TryParse(input2, out parsedGame2);
//    if (isEnumValue2 == false)
//    {
//        Console.WriteLine("Error");
//        break;
//    }

//    if (input1 == input2)
//    {
//        Console.WriteLine("Nobody wins");
//    }
//    else if ((input1 == "r" && input2 == "s") || (input1 == "s" && input2 == "p") || (input1 == "p" && input2 == "r"))
//    {
//        Console.WriteLine("Player 1 wins");
//    }
//    else
//    {
//       Console.WriteLine("Player 2 wins");
//    }


//    Console.WriteLine("Would you like to continue? y/n");
//    var input3 = Console.ReadLine();    

//    if (input3 == "y")
//    {
//        continue;
//    }
//    else
//    {
//       Console.WriteLine("Bye");
//        break;
//    }
//}
//while(true);

using System.IO;

using (StreamWriter writer = new StreamWriter(@"C:\Users\anass\source\repos\GrandCircus/important.txt"))
{
    writer.Write("Here ");
    writer.WriteLine("is");
    writer.WriteLine("Some text");

}

//using (StreamWriter writer = new StreamWriter("C:/GC_MidtermProject1/important.txt"))
//{
//    writer.Write("Here ");
//    writer.WriteLine("is");
//    writer.WriteLine("Some text");
//}

////JSON is a data structure ---> convert it to C# object
////key, value

//{
//    "name": "Buick Le Sabre",
//  "price": 10000,
//  "isForSale": true,
//  "previousOwners": ["Joe Doe", "Bob Vance", "Ted Mosby", "Phul Pritchett", "Michael Scott"],
//}










