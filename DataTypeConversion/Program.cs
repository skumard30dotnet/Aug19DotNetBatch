using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//User Defined Namespace
namespace DataTypeConversion
{
   /*Type conversion happens when we assign the value of one data type to another.If the data types are compatible, then C# does Automatic Type Conversion. If not comparable, then they need to be converted explicitly which is known as Explicit Type conversion. For example, assigning an int value to a long variable.*/
   // Ctrl + K + C

    class Program
    {
        static void Main(string[] args)
        {
            short sEmpId = 5000;
            int iEmpNo = sEmpId; // Implicit Conversion
            long lEmpNum = 123456789; // Implicit Conversion

            short sTempVar = (short)lEmpNum; //Type Casting

            Console.WriteLine("The value of sTempVar is : " + sTempVar);
            Console.WriteLine("The value of sEmpId : {0}, iEmpNo : {1}, sTempVar is : {2}",sEmpId, iEmpNo, sTempVar);
            Console.WriteLine("Welcome to CSharp session");

            double dVar = 12344.5667;
            int i = (int)dVar; // Explicit Conversion

            Console.WriteLine("The value of I is {0}", i);

            Console.Read();
        }
    }
}
