using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class PartialClass
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The result of c is {0}", c);
        }
    }

    partial class PartialClass
    {
        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("The result of c is {0}", c);
        }
    }
}
