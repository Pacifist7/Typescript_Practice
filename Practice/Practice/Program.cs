/*Console.WriteLine("Choose a number");
            var input = Console.ReadLine();
            int userIntegerInput;
            bool inputInteger = int.TryParse(input, out userIntegerInput);
            if (inputInteger==true)
            {
                Console.WriteLine("Cool");
            }
            else
            {
                Console.WriteLine("Not an integer, try again.");

            }
  //Lower and Upper trim

            string firstExampleString = "THIS IS ALL UPPER CASE";
            Console.WriteLine(firstExampleString);

            //make it lower case
            firstExampleString = firstExampleString.ToLower();

            Console.WriteLine(firstExampleString);
            Console.WriteLine("Error");

 //String.Compare()

            string firstStringToCompare = "Wow";
            string secondStringToCompare = "Oopla";

            var comparison = String.Compare(firstStringToCompare, secondStringToCompare);
            Console.WriteLine(comparison);

            string sameStringToCompare1 = "Wow";
            string sameStringToCompare2 = "Wow";

            var comparison2 = String.Compare(sameStringToCompare1, sameStringToCompare2);
            Console.WriteLine(comparison2);

      //String.Contains

            string containerString = "One two three four";
            string secondaryString = "three";

            var containsString = containerString.Contains(secondaryString.ToLower());

            if (containsString)
            {
                Console.WriteLine("Yup");
            }
            else
            {
                Console.WriteLine("Nope");

            }
 var firstString = "Hello there!";
            var secondString = "How are you today?";
            var thirdString = "We're doing string concatenation";

            var fourthString = String.Concat(firstString, secondString, thirdString);

            //var thirdString = firstString + secondString;

            Console.WriteLine(fourthString);

    //var firstString = "Hi what up? ";

            //firstString += "My name is Malik";

            //Console.WriteLine(firstString);
//EXERCICSE 21
            //Prompt the user to enter a series of words.
            //Once the user is done entering the words, output a sentence containing all the words.



            //var value = true;
            //do
            //{

            //    Console.WriteLine("Please enter a word: ");
            //    var input = Console.ReadLine();
            //    Console.WriteLine("Would you like to enter a new word? y/n");
            //    var answer = Console.ReadLine();

            //    if (answer=="y")
            //    {
            //        Console.WriteLine("What word would you like to enter?");
            //        var answer2 = Console.ReadLine();
            //        answer2 += answer;
            //        Console.WriteLine(answer2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(answer);
            //    }


            //}
            //while (value);

            //String Interpolation

            //var firstName = "John";
            //var lastName = "Smith";

            //var fullName = $"This person's first name is {firstName} and their last name is {lastName}";

            //SubStrings

            //string longSentence = "It was the best of times, it was the worst of times";

            //string exampleWord = "German Shepard";

            //Console.WriteLine(exampleWord[0]);

            //Console.WriteLine(exampleWord.Substring(7, 2));

            // string longSentence = "It was the best of times, it was the worst of times";

            //string exampleWord = "German Shepard";

            //EXERCISE 24

            //Prompt the user to enter a string.  Extract and output the last ten characters of the string.

            Console.WriteLine("Enter a word");
            var input = Console.ReadLine();
            int lengthString = input.Length;
            if (lengthString<=10)
            {
                Console.WriteLine(input);
            }
            else
            {

            }
            Console.WriteLine(input.Substring(lengthString - 10));

   //EXERCISE 18 SOLUTION

            //Description
            //Prompt the user to enter a number.
            //Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.

            Console.WriteLine("Choose a number: ");
            var input = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0 ; i <= input ; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);

l
 //EXERCISE 19

            //Description
            //Prompt the user to enter two numbers.
            //Use a for-loop to calculate the sum of all the numbers
            //from the first number entered to the second.

            Console.WriteLine("Choose the first number: ");
            var inputMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the second number: ");
            var inputMax = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = inputMin; i <= inputMax; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);

   //EXERCISE 20

            //Description
            //Prompt the user to enter a number.  
            //Use a for-loop to calculate the product of the number and the two preceeding numbers.

            Console.WriteLine("Choose a number: ");
            var input = int.Parse(Console.ReadLine());

            var product = 1;

            for (int i = 0; i <= input; i++)
            {
                product = input * (input - 1) * (input - 2);
            }

            Console.WriteLine(product);
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrayList = new ArrayList();

            //arrayList.Add("Banana");
            //arrayList.Add(5);
            //arrayList.Add(true);

            //List<string> name = new List<string>();
            //name.Add("Orange");
            //name.Add("Banana");
            //name.Add("Apple");

            //Console.WriteLine(string.Join(",", name));

            //name.Remove("Banana");
            //Console.WriteLine(string.Join(",", name));

            //List<int> listOfIntegers = new List<int>()
            //{
            //    10,
            //    2500,
            //    15,
            //    35,
            //    37,
            //    1050
            //};

            ////Array has a set number of elements
            ////List does not have a set number of elements, we can add and subtract elements

            //string[] stringArray = new string[3] { "uhyvg", "liyvg", "liygvi" };

            //Console.WriteLine(listOfIntegers.Count());

            //var thisNum = listOfIntegers[0];

            //int GetCountOfList(List<int> listOfInt)
            //{
            //    return listOfInt.Count();
            //}

            //Console.WriteLine(GetCountOfList(listOfIntegers));

            //Dictionariy<key,value>

            //Dictionary<string, string> dictionaryWords = new Dictionary<string, string>();

            //dictionaryWords.Add("Bob", "He lives in CT");
            //dictionaryWords.Add("Joe", "He lives in NJ");
            //dictionaryWords.Add("Steve", "He lives in MI");

            ////Console.WriteLine(dictionaryWords["Steve"]);
            //Console.WriteLine(dictionaryWords["Joe"]);

            //foreach(KeyValuePair<string,string> keyValuePair in dictionaryWords)
            //{
            //    Console.WriteLine(keyValuePair.Key);
            //    Console.WriteLine(keyValuePair.Value);
            //}

            var value = true;
            do
            {
                Dictionary<string, string> dictionaryWords = new Dictionary<string, string>()
                {
                    { "Hey", "Salut"},
                    { "Squirrel", "Ecureuil"},
                    { "Slippers", "Pantoufles"},
                    { "Beach", "Plage"},
                    { "Computer", "Ordinateur"}
                };

                Console.WriteLine("Please enter a word in English from the following selection: 'Hey', 'Squirrel', 'Slippers', Beach', 'Computer'");

                var answer = Console.ReadLine();

                if (dictionaryWords.ContainsKey($"{answer}"))
                {


                    Console.WriteLine($"{answer} in French is {dictionaryWords[answer]}");

                    Console.WriteLine("Would you like to continue? y/n");

                    var answer2 = Console.ReadLine();

                    if (answer2 == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Your entry is not in this dictionary");
                }
            }
            while (value == true);
        }
        
    }


}
