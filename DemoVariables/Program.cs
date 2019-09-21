
// System Defined Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// User Defined Namespace
namespace DemoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyteVar = 127;
            byte byteVar = 255;
            int x = 10;
            short y = 100;
            float flt = 123.345f;
            double dble = 245.567;
            decimal dcml = 234345465.567567567m;

            string str = null; // Null object
            str = ""; // Empty String
            str = string.Empty; // Rigt way of defining 
            //Explicit Conversion
            int intStr = Convert.ToInt32(str);
            int newValue = int.Parse(str);

            Console.WriteLine("The value of sbyteVar is : {0}", sbyteVar);

            Console.Read();
        }

    }
}
