using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Sep19_Polymorpshim
{
    class OrderofParameters
    {
        int c = 0;

        public void Add(int a, string b)
        {
            c = a + Convert.ToInt32(b);
            Console.WriteLine("The Addition result is {0}", c);
        }

        public void Add(string a, int b)
        {
            this.c = Convert.ToInt32(a) + b;
            Console.WriteLine("The Addition of three number and the result is {0}", c);
        }
    }
}
