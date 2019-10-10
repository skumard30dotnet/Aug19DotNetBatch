using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Oct19_DemoList
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10; // Variable where we can store only one value at a time
            int[] y = new int[10]; // Array Collection can store multiple values to the same variable

            List<int> lst2 = new List<int>() { 60,70,80};

            List<int> lst = new List<int>(); // Dynamically the memory size gets adjusted of its own
            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(50);
            lst.Add(30);

            lst.Insert(2, 40);
            lst.Reverse();
            lst.Remove(20);
            lst.Sort();

            lst.AddRange(lst2); // Concatenating the list with another list
            lst.Capacity = 10; // Setting the size of the list
            //lst.Clear(); // clear the list
            Console.WriteLine("The value is Present({0})", lst.Contains(30)); // Give true or false
            lst.CopyTo(y);
            Console.WriteLine("Count is {0}", lst.Count);

            foreach (int i in lst)
            {
                Console.WriteLine("The value of i is {0}", i);
            }


            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(4, "Four");
            //dict.Add(4, "Four");

            foreach (var keyvalue in dict)
            {
                Console.WriteLine("Key is {0}", keyvalue.Key);
                Console.WriteLine("Value is {0}", keyvalue.Value);
            }

            Console.Read();
        }
    }
}
