using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Sep19_DemoInheritance1
{
    class ScientificCalcualtor : Calculator
    {
        int c = 0;
        public ScientificCalcualtor(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }

        public void Sin(int a)
        {
            Math.Sin(a);
            Console.WriteLine("The sin value is {0}", a);
        }
    }
}
