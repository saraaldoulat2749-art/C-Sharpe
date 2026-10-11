using System;
using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Part 1 - Guessing Game
            Console.WriteLine("===== Guessing Game =====");
            Random random = new Random();
            int secretNumber = random.Next(50, 76);
            int guess = 0;
            int attempts = 0;
            int points = 0;
            while (guess != secretNumber)
            {
                Console.Write("Guess a number between 50 and 75: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;
                if (guess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Try a lower number.");
                }
                else
                {
                    Console.WriteLine("Congratulations!");
                }
            }
            // Calculate points

            if (attempts == 1)
            {
                points = 10;
            }
            else if (attempts == 2)
            {
                points = 7;
            }
            else if (attempts == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }
            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Points: " + points);
            // Part 2 - School System

            string[] students =
            {
                "Ahmad",
                "Sara",
                "Omar",
                "Lina",
                "Yazan"
            };
            int[] grades =
            {
                85,
                92,
                68,
                75,
                90
            };
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    // Display Students
                    case 1:
                        Console.WriteLine("Students Names:");

                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;
                    // Search for Student
                    case 2:
                        Console.Write("Enter student name: ");
                        string searchName = Console.ReadLine();
                        int index = 0;
                        bool found = false;
                        while (index < students.Length)
                        {
                            if (students[index] == searchName)
                            {
                                Console.WriteLine("Student Found!");

                                found = true;

                                break;
                            }
                            index++;
                        }
                        if (found == false)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;
                    // Check Student Result
                    case 3:
                        Console.Write("Enter student's grade: ");
                        int grade = int.Parse(Console.ReadLine());

                        if (grade >= 90 && grade <= 100)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (grade >= 80)
                        {
                            Console.WriteLine("Very Good");
                        }

                        else if (grade >= 70)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (grade >= 60)
                        {
                            Console.WriteLine("Pass");
                        }

                        else
                        {
                            Console.WriteLine("Fail");
                        }
                        break;
                    // Exit
                    case 4:
                        Console.WriteLine("Exit Program...");
                        break;
                    default:

                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 4);
        }
    }
}
