using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Sep19_Polymorpshim
{
    class NumberofParameters
    {
        int c = 0;

        public void Add(int a, int b)
        {
            c = a + b;
            Console.WriteLine("The Addition result is {0}", c);
        }

        public void Add(int a, int b, int c)
        {
            this.c = a + b + c;
            Console.WriteLine("The Addition of three number and the result is {0}", c);
        }
    }
}
