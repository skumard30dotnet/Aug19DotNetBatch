using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Oct19_Delegates
{
    /// <summary>
    //    /// A Delegate is an abstraction of one or more function pointers (as existed in C++; the explanation about this is out of the scope of this article). The .NET has implemented the concept of function pointers in the form of delegates. With delegates, you can treat a function as data. Delegates allow functions to be passed as parameters, returned from a function as a value and stored in an array. Delegates have the following characteristics: 
    //    Delegates are derived from the System.MulticastDelegate class.
    //They have a signature and a return type.A function that is added to delegates must be compatible with this signature.
    //Delegates can point to either static or instance methods.
    //Once a delegate object has been created, it may dynamically invoke the methods it points to at runtime.
    //Delegates can call methods synchronously and asynchronously.
    //The delegate contains a couple of useful fields. The first one holds a reference to an object, and the second holds a method pointer.When you invoke the delegate, the instance method is called on the contained reference.However, if the object reference is null then the runtime understands this to mean that the method is a static method.Moreover, invoking a delegate syntactically is the exact same as calling a regular function. Therefore, delegates are perfect for implementing callbacks.
    /// </summary>
    /// 

    public delegate int delOperations(int a, int b); 

    class DelegateOperations
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The addition result is {0}", c);
            return c;
        }

        public static int Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("The Subtraction result is {0}", c);
            return c;
        }
    }
}
