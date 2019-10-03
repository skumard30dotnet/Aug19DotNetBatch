using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Sep19_DemoInheritance1
{
    class AdvancedCalculator : ScientificCalcualtor
    {
        public AdvancedCalculator(int a, int b, int c) : base(a, b, c)
        {

        }

        public void Method1()
        {
            Console.WriteLine("Method 1 Called");
        }
    }
}
