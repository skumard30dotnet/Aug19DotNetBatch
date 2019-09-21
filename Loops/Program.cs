using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //for (; ; )
            //{
            //    if(i < 10)
            //        Console.WriteLine("The value of i is {0}", i);
            //    i++;
            //}

            // Break to stop the execution
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i == 500)
            //        break;
            //    Console.WriteLine("The value of i is {0}", i);
            //}


            // Contine skips the below lines of code
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        continue;
            //    Console.WriteLine("The value of i is {0}", i);
            //}

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("The value of i is {0}", i);
            //    ++i;
            //}

            //The program get executed even the condition is failed, since it checks the condition at the last
            //int i = 15;
            //do
            //{
            //    Console.WriteLine("The value of i is {0}", i);
            //    ++i;
            //} while (i<10);



            //Is Prime Number or not
            Console.WriteLine("Please enter the number");
            int primeNum = Convert.ToInt32(Console.ReadLine());

            bool flag = false;
            for (int i = 2; i < primeNum; i++)
            {
                
                int remainder = primeNum % i;
                if (remainder == 0)
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine("Its a prime number");
            }
            else
            {
                Console.WriteLine("Its not a prime number");
            }

            Console.Read();
        }
    }
}
