using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Declaring a class

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is {1}", to, Name);
        }
    }

    //Create a personal object from a string ---> Create a Parse method
    public static Person Parse(string str)
    {
        var person1 = new Person();
        person1.Name = str;
        return person1;
    }
   
    
    
    //Declaring Static Members

    public class Person2
    {
        public static int PeopleCount = 0;
    }
}
