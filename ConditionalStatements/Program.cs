using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 20;
            int c = 25;
            //Simple If
            //if (a > b)
            //{
            //    Console.WriteLine("A is bigger than b");
            //}

            //If ELSE Statement
            //if (a > b)
            //{
            //    Console.WriteLine("A is bigger than b");
            //}
            //else
            //{
            //    Console.WriteLine("B is bigger than A");
            //}

            // Biggest of 3 numbers
            // && Both condition should be true
            // || Any one condition should be true
            if (a > b)// Both conditions are true
            {
                if (a > c)
                {
                    Console.WriteLine("A is bigger");
                }
                else
                {
                    Console.WriteLine("C is bigger");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("B is bigger");
            }
            else
            {
                Console.WriteLine("C is bigger");
            }



            Console.Read();
        }
    }
}
