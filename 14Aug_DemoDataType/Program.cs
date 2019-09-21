using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Aug_DemoDataType
{
    class Program
    {
        int empId = 0; // Global Variable -- The scope of this variable is limited to the entire class

        static void Main(string[] args)
        {
            int defaultValue = 0;
            
            System.SByte age = 34; //8 bits --> -127 to 127
            byte bAge = 244;  //8 bits --> 0-255
            
            short salary = 10000; //16 Bits
            ushort uSalary = 100;

            int no = 400; //32 bits
            long complexNumber = 348093248023948; // 64 bits

            string employeeName = "Ravi"; // String
            char c = 'a'; //Single quote

            float fValue = 123.34f; //for float you have to use 'f' keyword at the last (32 bits)
            double dValue = 9234872938472.92837982347; //(64 bits)
            decimal decValue = 99234.234709m; //for float you have to use 'm' keyword at the last (128 bits)
            Console.WriteLine("Default Value ", defaultValue);
            Console.WriteLine("The Employee Name is  and Age is " + employeeName + age);
            Console.WriteLine("The Employee Name is " + employeeName + " and Age is " + age);
            Console.WriteLine("The Employee Name is {0} and Age is {1}", employeeName, age);
            Console.WriteLine("The byte Age is " + bAge);
            Console.WriteLine("Char value ", c);
            Console.WriteLine("Short Max Size : {0}", short.MaxValue);
            Console.WriteLine("Short Min Size : {0}", short.MinValue);
            Console.ReadLine();
        }
    }
}
