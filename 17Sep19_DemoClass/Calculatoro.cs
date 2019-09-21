using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Sep19_DemoClass
{
    /// <summary>
    /// Class Accessmodifer can be public or internal
    /// By default the access modifier of a class is internal
    /// Accessmodifier is option for both class and methods
    /// </summary>
    class Calculator
    {
        public void Add()
        {
            Console.WriteLine(10 + 20);
        }

        public void Sub(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sub of A{0} & B{1} is : {2}", a, b, c);
        }

        public int Mul(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public void Display()
        {
            Add();
        }
    }
}
