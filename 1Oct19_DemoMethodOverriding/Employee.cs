using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Oct19_DemoMethodOverriding
{
    class Employee
    {
        public virtual void DisplayEmployee(int id, string name)
        {
            Console.WriteLine("The Employee Id is {0}, Employee Name is {1}", id, name);
        }

        public void Salary()
        {

        }

    }

    class Student : Employee
    {
        public override void DisplayEmployee(int id, string name)
        {
            Console.WriteLine("The Employee Id is {0}, Employee Name is {1}", id, name);
        }

        public void Admission()
        {

        }
    }
}
