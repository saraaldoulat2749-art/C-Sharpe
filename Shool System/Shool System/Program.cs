using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sara";
            int age = 23;
            int grade = 12;
            double average = 91.6;
            char gender = 'F';
            bool active = true;


            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" +age);
            Console.WriteLine("Agrade :" +grade);
            Console.WriteLine("Average :"+average);
            Console.WriteLine("Gender :"+gender);
            Console.WriteLine("Active :"+active);

            //==============================//
         

            string[] names = { "Ahmad ", "Sara" ,"Omar" ,"Lina" };
            Console.WriteLine("Student 1:" + names[0]);
            Console.WriteLine("Student 2:" + names[1]);
            Console.WriteLine("Student 3:" + names[2]);
            Console.WriteLine("Student 4:" + names[3]);


            Console.WriteLine("Number of Students: "+names.Length);


            //==============================//

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);


            //=============================//


            names[2] = "Khaled";


            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);







        }
    }
}
