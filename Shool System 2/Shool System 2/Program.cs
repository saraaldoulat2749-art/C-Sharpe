using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool_System_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Student Name : ");
           string Name = Console.ReadLine();

            Console.Write("Student Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Grade : ");
            double Grade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Student Average : ");
            string Average = Console.ReadLine();

            Console.Write("Student Gender : ");
            string Gender = Console.ReadLine();

            Console.WriteLine("========================================");


            Console.WriteLine($"Welcome {Name} !");

            Console.WriteLine($"Name : {Name} ");
            

            Console.WriteLine($"Age : {Age} ");

            Console.WriteLine($"Grade : {Grade} ");

            Console.WriteLine($"Average : {Average} ");

            Console.WriteLine($"Gender : {Gender} ");

            Console.WriteLine("========================================");

            Console.WriteLine($"Original Name: {Name}");

            Console.WriteLine($"Uppercase: {Name.ToUpper()}");

            Console.WriteLine($"Lowercase: {Name.ToLower()}");

            Console.WriteLine($"First Character: {char.ToUpper(Name[0])}");

            Console.WriteLine("========================================");


            double average = 85.5;
            int bonus = 5;

            double newAverage = average + bonus;

            Console.WriteLine($"Original Average: {average}");
            Console.WriteLine($"Bonus Marks: {bonus}");
            Console.WriteLine($"New Average: {newAverage}");

            Console.WriteLine("========================================");

            bool passed = true;

            bool adult = true;

            Console.WriteLine($"Passed: {passed}");

            Console.WriteLine($"Adult: {adult}");

        }
    }
}
