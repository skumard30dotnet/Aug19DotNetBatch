using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Oct19_DemoMulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass dcls = new DelegateClass();

            delegateOperations delOps = new delegateOperations(dcls.Add);
            delOps += new delegateOperations(dcls.Sub);
            delOps += new delegateOperations(dcls.Mul);

            delOps(10, 4);

            delOps -= new delegateOperations(dcls.Sub);
            delOps(20, 8);

            Console.Read();


        }
    }
}
