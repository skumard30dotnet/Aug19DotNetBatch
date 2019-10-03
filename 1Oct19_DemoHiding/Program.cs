using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Oct19_DemoHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.DisplayEmployee(12, "Pragim");

            Student stud = new Student();
            stud.DisplayEmployee(15, "Ravi");

            Console.WriteLine("----------------------------------------------");

            Employee stud1 = new Student();
            stud1.DisplayEmployee(18, "Kumar");


            Console.Read();
        }
    }
}
