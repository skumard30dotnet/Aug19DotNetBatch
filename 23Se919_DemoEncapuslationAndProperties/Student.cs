using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Se919_DemoEncapuslationAndProperties
{
    class Student
    {
        int studId = 0; // Data Member
        string studName = string.Empty; // Data Member

        private const string Address = "Marathahalli";


        public Student(int studId, string name)
        {
            this.studId = studId;
            studName = name;
        }

        private int studAge = 10;

        public int StudAge
        {
            get { return studAge; }
            set { studAge = value; }
        }

        public DateTime StudDateofBirth { get; set; }


        /// <summary>
        /// Member Function
        /// </summary>
        public void DisplaySutdentInfo()
        {
            Console.WriteLine("Stud Id is {0}", studId);
            Console.WriteLine("Stud Name is {0}", studName);
        }

    }
}
