using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sep19_DemoConstStaticReadonly
{

    /// <summary>
    /// Const is nothing but "constant", a variable of which the value is constant but at compile time. And it's mandatory to assign a value to it. By default a const is static and we cannot change the value of a const variable throughout the entire program.
    /// 
    /// Readonly is the keyword whose value we can change during runtime or we can assign it at run time but only through the non-static constructor. Not even a method. Let's see:
    /// 
    /// A Static Readonly type variable's value can be assigned at runtime or assigned at compile time and changed at runtime. But this variable's value can only be changed in the static constructor. And cannot be changed further. It can change only once at runtime. Let's understand it practically.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StaticConstReadOnlyClass cls = new StaticConstReadOnlyClass();
            // cls.readOnlyVariable = "second Valaue"; // Not allowed to modify the value of readonly

            StaticConstReadOnlyClass.staticVariable = 45345345;

            Console.WriteLine("Readonly Value : {0}", cls.readOnlyVariable);
            Console.WriteLine("Const Value : {0}", StaticConstReadOnlyClass.constantVariable);
            Console.WriteLine("Stataic Value : {0}", StaticConstReadOnlyClass.staticVariable);
        }
    }
}
