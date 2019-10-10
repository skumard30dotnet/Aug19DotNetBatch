using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Oct19_DemoGenericsConstraints
{
    //class Employee<Tkey, TValue> where Tkey : class
    //class Employee<Tkey, TValue> where Tkey : struct
    class Employee<Tkey, TValue> where Tkey : struct where TValue : class
    {
        public void EmpInfo(Tkey id, TValue name)
        {
            Console.WriteLine("The Employee Id is {0}", id);
            Console.WriteLine("The Employee Name is {0}", name);
        }
    }
}
