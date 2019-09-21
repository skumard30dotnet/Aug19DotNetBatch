using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Sep19_DemoConstructors1
{
    class Calculator
    {
        // Global Variable
        int a;
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
            Console.WriteLine("The sum of a & b is : {0}", c);
        }


        public void Sub()
        {
            c = a - b;
            Console.WriteLine("The sub of a & b is : {0}", c);
        }

        public void Mul()
        {
            c = a * b;
            Console.WriteLine("The mul of a & b is : {0}", c);
        }
    }
}
