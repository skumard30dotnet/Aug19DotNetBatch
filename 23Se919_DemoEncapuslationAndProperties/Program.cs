using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Se919_DemoEncapuslationAndProperties
{
    /// <summary>
    /// Encapsulation is defined as the wrapping up of data under a single unit. It is the mechanism that binds together code and the data it manipulates. In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.

//Technically in encapsulation, the variables or data of a class are hidden from any other class and can be accessed only through any member function of own class in which they are declared.
//As in encapsulation, the data in a class is hidden from other classes, so it is also known as data-hiding.
//Encapsulation can be achieved by: Declaring all the variables in the class as private and using C# Properties in the class to set and get the values of variables.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student(1,"Pragim");
            stud.DisplaySutdentInfo();

            stud.StudAge = 10; // Assignment
            int age = stud.StudAge; // Read the value of the property


            stud.StudDateofBirth = System.DateTime.Now;
            DateTime dt = stud.StudDateofBirth;


            Console.Read();
        }
    }
}
