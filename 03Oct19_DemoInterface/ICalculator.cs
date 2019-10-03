using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Oct19_DemoInterface
{
    interface ICalculator1
    {
        //Not allowed to create an instance of a class
        // Implement the interface in the derived class
        //Interface does not allow variables declaration
        // All the methods of interface to be implemented in the derived class
        //int x = 0;

        // Interface member function does not have definition, it should have only declaration
        // Access Modifiers are not allowed on interface, by default its public
        void Add(int a, int b);
        //{
        //    int c = a + b;
        //}

        void Sub(int a, int b);
    }

    interface ICalculator2
    {
        void Mul(int a, int b);
        void Div(int a, int b);
    }

    public class CalculatorClient1 : ICalculator1
    {
        public void Add(int a, int b)
        {
            int c = a + b;

            Console.WriteLine("The Addition result is {0}", c);
        }

        public void Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatorClient2 : ICalculator2
    {
        public void Mul(int a, int b)
        {
            int c = a * b;

            Console.WriteLine("The Mul result is {0}", c);
        }

        public void Div(int a, int b)
        {
            int c = a / b;

            Console.WriteLine("The Div result is {0}", c);
        }
    }

    public class CalculatorClient3 : ICalculator1, ICalculator2
    {
        public void Add(int a, int b)
        {
            int c = a + b;

            Console.WriteLine("The Addition result is {0}", c);
        }

        public void Sub(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Mul(int a, int b)
        {
            int c = a * b;

            Console.WriteLine("The Mul result is {0}", c);
        }

        public void Div(int a, int b)
        {
            int c = a / b;

            Console.WriteLine("The Div result is {0}", c);
        }
    }
}
