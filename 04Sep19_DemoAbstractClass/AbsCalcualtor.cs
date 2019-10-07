using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Sep19_DemoAbstractClass
{
    /// <summary>
    /// //Not allowed to create an instance of a class
    // Implement the Abstract in the derived class
    //Abstract allows variables declaration
    // All methods are abstract and non abstract
    // All the methods of abstract to be implemented in the derived class
    //int x = 0;

    // Abstract member function does not have definition, it should have only declaration
    /// </summary>
    abstract class AbsCalcualtor
    {
        public abstract void Add(int a, int b);

        public abstract void Sub(int a, int b);

        public void Display(string msg, int result)
        {
            Console.WriteLine("{0}, {1}", msg, result);
        }
    }

    class Calcualtor : AbsCalcualtor
    {
        public override void Add(int a, int b)
        {
            int c = a + b;
            Display("The Addition result is ", c);
        }

        public override void Sub(int a, int b)
        {
            //throw new NotImplementedException();
        }
    }
}
