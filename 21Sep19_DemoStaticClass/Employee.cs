using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sep19_DemoStaticClass
{
    static class StaticEmployee
    {
        static int empId = 0;
        static string empName = string.Empty;

        public static void DisplayEmployee(int empId, string empName)
        {
            Console.WriteLine("The employeedId is {0}, Name is {1}", empId, empName);
        }
    }

    class NonStataicEmployee
    {
        int nonstaticempId = 0;
        static string staticEmpName = string.Empty;

        public static void StaticDisplayEmployee(int empId, string empName)
        {
            Console.WriteLine("The employeedId is {0}, Name is {1}", empId, empName);
        }

        public void NonStaticDisplayEmployee(int empId, string empName)
        {
            Console.WriteLine("The employeedId is {0}, Name is {1}", empId, empName);
        }
    }
}
