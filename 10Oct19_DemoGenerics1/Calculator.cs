using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Oct19_DemoGenerics1
{
    class Calculator<T>
    {
        public T Add(T a, T b)
        {
            Console.WriteLine("The value of a is {0}", a);
            Console.WriteLine("The value of b is {0}", b);
            //var c = a + b;

            return default(T);
        }
    }

    class Calculators<TKey, TValue>
    {
        public void Add(TKey a, TValue b)
        {
            Console.WriteLine("The value of a is {0}", a);
            Console.WriteLine("The value of b is {0}", b);
            //var c = a + b;
        }
    }
}
