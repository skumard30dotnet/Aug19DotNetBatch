using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Aug19_DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] x = new int[10];
            //x[0] = 10;
            //x[1] = 20;
            //x[2] = 30;
            //x[3] = 40;
            //x[4] = 50;

            //for (int j = 0; j < x.Length; j++)
            //{
            //    Console.WriteLine("The value of J[{0}] is {1}", j, x[j]);
            //}

            //string[] str = new string[5];
            //str[0] = "Zero";
            //str[1] = "One";
            //str[2] = "Two";
            //str[3] = "Three";
            //str[4] = "Four";

            //int k = 0;
            //foreach (string vari in str)
            //{
            //    Console.WriteLine("The value of J[{0}] is {1}",k, vari);
            //    k++;
            //}

            Console.WriteLine("Please enter the value between 1 - 3");
            int inputValue = Convert.ToInt32(Console.ReadLine());

            switch (inputValue)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("You should enter value between 1 - 3");
                    break;
            }


          

            Console.Read();

            
        }
    }
}
