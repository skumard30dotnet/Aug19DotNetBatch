using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass cls = new PartialClass();
            cls.Add(10,5);
            cls.Sub(10,4);

            Console.Read();
        }
    }
}
