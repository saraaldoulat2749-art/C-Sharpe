using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System._3
{
    internal class Student
    {
        public string name;
        public int age;
        public double grade;

        public Student()
        {
        }
        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine($"Student Name:{name}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Grade:{grade}");
        }
    }
} 
