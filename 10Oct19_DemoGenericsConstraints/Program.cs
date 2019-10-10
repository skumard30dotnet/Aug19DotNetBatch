using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Oct19_DemoGenericsConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int, string> emp = new Employee<int, string>();
            emp.EmpInfo(12, "Pragim");

            //Employee<object, object> emp1 = new Employee<object, object>();

            Console.Read();
        }
    }
}
