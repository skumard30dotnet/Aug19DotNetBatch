using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass cls = new SealedClass();
            cls.Display();

            Console.WriteLine();
        }
    }
}
