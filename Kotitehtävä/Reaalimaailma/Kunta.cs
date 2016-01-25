using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaalimaailma
{
    class Kunta : Alue
    {
        private double people;
        private readonly double minPeople = 0;
        public string Name;

        public Kunta(string name)
        {
            Name = name;
        }

        public double People
        {
            get
            {
                return people;

            }
            set
            {
                if (value >= minPeople)
                {
                    people = value;
                }
                else
                {
                    Console.WriteLine("Jees homma, negatiivinen väkiluku.");
                }
            }
        }
    }
}
