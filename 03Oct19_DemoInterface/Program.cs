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

            Console.Read();
        }
    }
}
