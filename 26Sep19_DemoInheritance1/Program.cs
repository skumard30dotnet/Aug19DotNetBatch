using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Sep19_DemoInheritance1
{
    /// <summary>
    /// 1. Single Inheritance
    /// 2. Multiple Inheritance
    /// 3. MultiLevel Inheritance
    /// 4. Hybrid Inheritance
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calc = new Calculator(12,4);
            //calc.Add();
            //calc.Sub();

            //ScientificCalcualtor sCalc = new ScientificCalcualtor();
            //sCalc.Sin(5);

            //ScientificCalcualtor scalc = new ScientificCalcualtor(20, 10, 30);
            //scalc.Add();
            //scalc.Sub();
            //scalc.Sin(10);

            AdvancedCalculator aCalc = new AdvancedCalculator(10, 5, 20);
            aCalc.Add();
            aCalc.Sub();
            aCalc.Sin(10);
            aCalc.Method1();

            Console.Read();
        }
    }
}
