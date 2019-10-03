using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Sep19_Polymorpshim
{
    /// <summary>
    /// Polymorphism
    /// 1. Static Polymorphism
    ///     a. Method Overloading
    ///         1. Number of parameters
    ///         2. Order of Parameters
    ///         3. Different Types of parameters
    ///     b. Operator Overloading
    /// 2. Dynamic Polymorphsim
    ///     a. Method Overriding
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DifferentTypeofParameters parm = new DifferentTypeofParameters();
            parm.Add(10, 20, 30);
            parm.Add(10, 20);
            parm.Add("10", "20");
        }
    }
}
