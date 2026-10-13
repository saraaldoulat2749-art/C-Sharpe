using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected string SchoolName{ get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name :{ Name}");
            Console.WriteLine($"Age : {Age}");

        }

        private string _internalCode;//لانها من نوع برايفت بقدر استدعيها فقط داخل السكوب
    }
    class Student : Person
    {
        public int Grade { get; set; }

        public string StudentId { get; set; }

        public void DisplayStudentInfo()
        {
            SchoolName = "ABC School";

            DisplayInfo();

            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("School Name: " + SchoolName);
        }

    }


    class Teacher : Person
    {
       public string Subject {  get; set; }

        public Teacher(string name, int age, string subject) {
            Name = name;
            Age = age;
            Subject = subject;
        }

        public void DisplayTeacherInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Subject : {Subject}");

        }
    }

 

    sealed class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string title)
        {
            ReportTitle = title;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine($"Report Title: {ReportTitle}");
        }
    }

    
    // because the class is sealed.
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Student s1 = new Student();
            s1.Name = "Sara";
            s1.Age = 20;
            s1.Grade = 95;
            s1.DisplayInfo();


            Student s2 = new Student();
            s2.Name = "Salma";
            s2.Age = 23;
            s2.Grade = 90;
            s2.DisplayInfo();

            Teacher t1 = new Teacher("Ahmad", 25, "Math");
            t1.DisplayTeacherInfo();



            //  Console.WriteLine(p1.SchoolName);
            // is protacted
            // Console.WriteLine(p1._internalCode);
            // is private


    
            SchoolReport report = new SchoolReport("Student Report");
            report.DisplayReportTitle();
            
        }
    }
}
