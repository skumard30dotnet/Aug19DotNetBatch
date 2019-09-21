using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sep19_DemoConstructor2
{
    class Employee
    {
        int empId = 0;
        string name = string.Empty;

        public Employee(int empId, string name)
        {
            this.empId = empId;
            this.name = name;
        }

        public Employee(Employee emp)
        {
            empId = emp.empId;
            name = emp.name;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("The EmployeeId is : {0}, Name is : {1}", empId, name);
        }
    }
}
