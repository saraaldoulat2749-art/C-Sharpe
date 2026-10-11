using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "1234";

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                

                if (string.IsNullOrWhiteSpace(password)) //" " "" // always is return false or true
                {
                    Console.WriteLine("Password cannot be empty!");
                    continue;
                }

                if (password == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }

                Console.WriteLine("Wrong password!");
            }

            Console.WriteLine("Program finished.");
        }
    }
}
