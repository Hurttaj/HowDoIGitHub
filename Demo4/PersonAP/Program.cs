using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Age = 35;
            person.Address = "Piippukatu 2";
            person.PhoneNumber = "02014332432";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Age = 40;
            teacher.Address = "Piippukatu 1";
            teacher.PhoneNumber = "435432523";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Lasse", "Laiska", "T1337");
            student.Age = 19;
            student.Address = "Piippukatu 5";
            student.PhoneNumber = "79863534523";
            Console.WriteLine(student.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();

            
        }
    }
}
