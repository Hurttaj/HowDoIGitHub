using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekisteri
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from Persons
            Persons myFriends = new Persons();

            // create a friends
            Person person1 = new Person { FirstName = "Jussi", LastName = "Jurkka", SSN = "101010-1337" };
            Person person2 = new Person { FirstName = "Etunimi", LastName = "Sukunimi", SSN = "123456789" };
            Person person3 = new Person { FirstName = "Omaperäisyys", LastName = "Kuolee", SSN = "6543210" };

            // add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // print collection
            myFriends.PrintCollection();

            Console.WriteLine("Get one person from collection:");
            Person person4 = myFriends.GetPerson(2);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in register.");
            }

            //find person with SSN
            string sSN = "101010-1337";
            Console.WriteLine("Find person with SSN: " + sSN);
            Person person5 = myFriends.FindPerson(sSN);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Not found.");
            }
        }
    }
}
