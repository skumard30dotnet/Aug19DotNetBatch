using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Oct19_DemoGenerics1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> calc = new Calculator<int>();
            calc.Add(10, 20);

            Calculator<string> calcStr = new Calculator<string>();
            calcStr.Add("ABC", "DEF");

            Console.Read();
        }
    }
}
