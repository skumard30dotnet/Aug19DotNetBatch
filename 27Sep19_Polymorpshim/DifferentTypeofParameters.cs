using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Sep19_Polymorpshim
{
    class DifferentTypeofParameters
    {
        int c = 0;

        public void Add(string a, string b)
        {
            string e = a + b;
            Console.WriteLine("The Concatenation result is {0}", e);
        }

        public void Add(int a, int b)
        {
            this.c = a + b;
            Console.WriteLine("The Addition result is {0}", c);
        }

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

       

        //public void Add(int a, int b)
        //{
        //    c = a + b;
        //    Console.WriteLine("The Addition result is {0}", c);
        //}

        public void Add(int a, int b, int c)
        {
            this.c = a + b + c;
            Console.WriteLine("The Addition of three number and the result is {0}", c);
        }
    }
}
