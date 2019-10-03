using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Sep19_DemoInheritance1
{
    class Calculator
    {
        int a = 0;
        int b = 0;
        int c = 0;

        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Add()
        {
            c = a + b;
            Console.WriteLine("The Add value is {0}", c);
        }

        public void Sub()
        {
            c = a - b;
            Console.WriteLine("The Sub value is {0}", c);
        }
    }

}
