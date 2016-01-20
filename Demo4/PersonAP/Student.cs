using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAP
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }
        public Student(string firstName, string lastName, string studentID) 
            : base (firstName,lastName)
        {
            StudentID = studentID;
        }


        public void StudentMethod()
        {
            Console.WriteLine("Mlrglrglrglrlg");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
