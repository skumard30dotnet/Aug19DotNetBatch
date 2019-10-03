using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Oct19_DemoHiding
{
    class Employee
    {
        public void DisplayEmployee(int id, string name)
        {
            Console.WriteLine("The Employee Id is {0}, Employee Name is {1}", id, name);
        }

        public void Salary()
        {

        }

    }

    class Student : Employee
    {
        public new void DisplayEmployee(int id, string name)
        {
            Console.WriteLine("The Employee Id is {0}, Employee Name is {1}", id, name);
        }

        public void Admission()
        {

        }
    }
}
