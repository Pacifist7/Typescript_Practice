using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();

            Console.Write("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What year is it?");
            int year = int.Parse(Console.ReadLine());

            int birthYear = year - age;

            Console.WriteLine(name + ",if you are" + age + "years old" + ",you were probably born in" + birthYear);
        }

    }
}
