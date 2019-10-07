using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Oct19_DemoMulticastDelegate
{
    public delegate void delegateOperations(int a, int b);

    class DelegateClass
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The Addition result is {0}", c);
        }

        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("The Subtraction result is {0}", c);
        }

        public void Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("The Multiplication result is {0}", c);
        }
    }
}
