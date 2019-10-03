using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Oct19_DemoMethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.DisplayEmployee(100, "Mani");

            Employee stud2 = new Student();
            stud2.DisplayEmployee(200, "Hari");
        }
    }
}
