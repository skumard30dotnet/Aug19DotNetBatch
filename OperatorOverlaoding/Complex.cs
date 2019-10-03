using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverlaoding
{
    class Complex
    {
        private int x;
        private int y;

        public Complex()
        {

        }

        public Complex(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }
    }
}
