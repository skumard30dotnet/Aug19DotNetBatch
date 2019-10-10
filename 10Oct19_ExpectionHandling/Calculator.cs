using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Oct19_ExpectionHandling
{
    class Calculator
    {
        //public void Division(int a, int b)
        //{
        //    if (b > 0)
        //    {
        //        int c = a / b;

        //        Console.WriteLine("The division value is {0}", c);
        //    }
        //    else
        //    {
        //        Console.WriteLine("The Denominator cannot be zero");
        //    }

        //}

        public void Division(int a, int b)
        {
            try
            {
                int c = a / b;
                Console.WriteLine("The division value is {0}", c);
            }
            catch (Exception e)
            {
                Console.WriteLine("The denominator cannot be zero ({0})", e.Message);
                Console.WriteLine("The stack trace is {0}", e.StackTrace);
            }
        }


        public void Division1(int a, int b)
        {
            try
            {
                int c = a / b;
                Console.WriteLine("The division value is {0}", c);
            }
            catch (Exception)
            {
                Console.WriteLine("The denominator cannot be zero");
            }
            finally
            {

            }
        }
    }
}
