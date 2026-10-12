using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School_System._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Ahmad";
            st1.age = 20;
            st1.grade = 85;
            st1.DisplayInfo();

            Student st2 = new Student();
            st2.name = "Sara";
            st2.age = 25;
            st2.grade = 80;
            st2.DisplayInfo();

            Student st3 = new Student();
            st3.name = "Omar";
            st3.age = 23;
            st3.grade = 70;
            st3.DisplayInfo();


            Student st4 = new Student("Ahmad", 20, 85);
            Student st5 = new Student("Sara", 21, 95);
            Student st6 = new Student("Omar", 19, 75);
            st4.DisplayInfo();
            st5.DisplayInfo();
            st6.DisplayInfo();


        }
    }
}
