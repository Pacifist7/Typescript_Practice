//CODE WARS

//KATA 1: Isograms

//An isogram is a word that has no repeating letters, consecutive or non-consecutive.
//Implement a function that determines whether a string that contains only letters is an isogram.
//Assume the empty string is an isogram. Ignore letter case.

//Example: (Input-- > Output)

//"Dermatoglyphics"-- > true
//"aba"-- > false
//"moOse"-- > false(ignore letter case)


//Solution

//static bool IsIsogram(string str)
//{
//    return str.ToLower().ToCharArray().Distinct().Count() == str.Count();
//}

//Console.WriteLine(IsIsogram("Aiden"));


//KATA2:Can you find the needle in the haystack?


//Write a function findNeedle() that takes an array full of junk but containing one "needle"

//After your function finds the needle it should return a message (as a string) that says:

//"found the needle at position " plus the index it found the needle, so:

//find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
//should return "found the needle at position 5"


//SOLUTION2

//static string FindNeedle(string[] array)
//{

//    if (array.Contains("Needle"))
//    {
//        int v = Array.FindIndex(array, item => item == "Needle");

//        return $"found the needle at position {v}.";
//    }
//    else
//    {
//        return "Needle not found.";
//    }
//}

//var array1 = new string[7] { "hay", "kjgdvf", "yudgvf", "iwu", "iudhcfbiu", "ifuwwgu", "Needle" };

//Console.WriteLine(FindNeedle(array1));

static bool IsPassing(double x)
{
    if (x > 65)
    {
        return true;
    }
    else
    {
        return false;
    }
}


static double AverageGrades(double g1, double g2, double g3)
{
    return (g1 + g2 + g3) / 3;
}


static string OddOrEvenAndPassing(double g)
{

    int intGrade = Convert.ToInt32(g);

    if (IsPassing(intGrade) == true && intGrade % 2 != 0)
    {
        return "passing and odd.";
    }

    else if (IsPassing(intGrade) == false && intGrade % 2 != 0)
    {
        return "failing and odd.";
    }

    else if (IsPassing(intGrade) == true && intGrade % 2 == 0)
    {
        return "passing and even.";
    }

    else
    {
        return "failing and even.";
    }
}








