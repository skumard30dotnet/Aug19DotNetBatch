using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    class BaseClass
    {

    }

    /// <summary>
    /// Sealed Class doenst support to be derived in other class
    /// Sealed class inherits other bases classes
    /// </summary>
    sealed class SealedClass : BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Sealed Class");
        }
    }

    class NonSealedClass : SealedClass
    {

    }
}
