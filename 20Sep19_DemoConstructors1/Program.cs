using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Sep19_DemoConstructors1
{
    /// <summary>
    /// Constructor of a class must have the same name as the class name in which it resides.
    /// 
    //A constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created.Like methods, a constructor also contains the collection of instructions that are executed at the time of Object creation.It is used to assign initial values to the data members of the same class.
//    Default Constructor
//Parametrized Constructor
//Copy Constructor
//Private Constructor
//Static Constructor

    //A constructor can not be abstract, final, static and Synchronized.
    //    Within a class, you can create only one static constructor.
    //    A constructor doesn’t have any return type, not even void.
    //A static constructor cannot be a parameterized constructor.
    //A class can have any number of constructors.
    //Access modifiers can be used in constructor declaration to control its access i.e which other class can call the constructor.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(10,5);
            calc.Add();
            calc.Sub();
            calc.Mul();
        }
    }
}
