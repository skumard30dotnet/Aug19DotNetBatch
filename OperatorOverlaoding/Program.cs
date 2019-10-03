using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverlaoding
{
    /// <summary>
    /// public static return_type operator op (Type1 t1, Type2 t2)  
        //{  
        ////Statements  
        //}
/// </summary>
class Program
    {
        static void Main(string[] args)
        {
            Complex com1 = new Complex(10,20);

            Complex com2 = new Complex(30,40);

            Complex com3 = com1 + com2;

            Console.Read();
        }
    }
}
