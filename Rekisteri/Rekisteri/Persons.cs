﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekisteri
{
    /// <summary>
    /// This clsas holds persons and gives a few methods...
    /// </summary>
    class Persons
    {
        /// <summary>
        /// persons holds person objects...
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Adds a person to collection
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        /// <summary>
        /// Returns a person to caller application.
        /// </summary>
        /// <param name="index">Person index in collection</param>
        /// <returns>Returned person object</returns>
        public Person GetPerson(int index)
        {
            if (index < persons.Count)
            {
                return persons.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public Person FindPerson(string sSN)
        {
            foreach(Person person in persons)
            {
                if (sSN.Equals(person.SSN))
                {
                    //person with sotu found
                    return person;
                }
               
            }
            return null;
        }

        public void PrintCollection()
        {
            Console.WriteLine("MRGLRGLRLGr");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }


    }
}
