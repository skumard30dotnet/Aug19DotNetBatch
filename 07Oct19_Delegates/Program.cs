using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Oct19_Delegates
{
    /// <summary>
    /// Single Cast Delegate
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DelegateOperations delOpsClass = new DelegateOperations();

            // Instance methods added to the delegate 
            delOperations delegateops = new delOperations(delOpsClass.Add);

            // Static method added to a delegate
            delOperations delegateops2 = new delOperations(DelegateOperations.Sub);

            delegateops(12,8);

            Console.Read();
        }
    }
}
