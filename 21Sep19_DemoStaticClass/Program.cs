using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sep19_DemoStaticClass
{
    /// <summary>
    /// 
    /// 
    //    /*
//    //     Static classes cannot be instantiated using the new keyword
//    Static items can only access other static items.For example, a static class can only contain static members, e.g., variables, methods, etc.A static method can only contain static variables and can only access other static items.
//  Static items share the resources between multiple users.
//  Static cannot be used with indexers, destructors or types other than classes.
//A static constructor in a non-static class runs only once when the class is instantiated for the first time.
//A static constructor in a static class runs only once when any of its static members accessed for the first time.
//Static members are allocated in high frequency heap area of the memory.
//   *
//   * /
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Example of Static Class
            StaticEmployee.DisplayEmployee(12, "Pragim");


            //2. Example of NonStatic Class
            NonStataicEmployee emp = new NonStataicEmployee();
            emp.NonStaticDisplayEmployee(15, "PragimTech");


            NonStataicEmployee.StaticDisplayEmployee(1234, "Pragim Technologies");

            Console.Read();
        }
    }
}
