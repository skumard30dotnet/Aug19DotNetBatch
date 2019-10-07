using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Sep19_DemoAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcualtor calc = new Calcualtor();
            calc.Add(10, 20);
            calc.Sub(20, 10);

            Console.Read();
        }
    }
}
