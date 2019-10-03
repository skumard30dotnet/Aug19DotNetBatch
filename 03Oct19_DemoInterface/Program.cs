using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Oct19_DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient1 calc = new CalculatorClient1();
            calc.Add(10, 20);
            calc.Sub(12, 34);

            CalculatorClient3 cli3 = new CalculatorClient3();
            cli3.Add(10, 20);
            cli3.Sub(20, 10);
            cli3.Mul(20, 3);

            ICalculator1 iCalc1 = new CalculatorClient3();
            iCalc1.Add(10, 30);
            iCalc1.Sub(10, 2);
            iCalc1.Display("SDf");


            Console.Read();
        }
    }
}

