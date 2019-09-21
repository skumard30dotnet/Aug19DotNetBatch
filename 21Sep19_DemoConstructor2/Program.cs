using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sep19_DemoConstructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(123, "Pragim");
            emp.DisplayEmployee();

            Employee empl = new Employee(emp);
            empl.DisplayEmployee();

            Console.Read();

        }
    }
}
