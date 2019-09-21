using _17Sep19_DemoClass.NewNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Sep19_DemoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int[] y = new int[4];

            Calculator calc = new Calculator();
            calc.Add();
            calc.Sub(20, 10);
            calc.Sub(30, 10);
            int result = calc.Mul(5, 6);
            Console.WriteLine("The multiplication value is : {0}", result);


            ScientificCalculator sCalc = new ScientificCalculator();
            //Calculator cal = new Calculator();
            //cal.

            Console.Read();
        }
    }
}
