using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotain
{
    class Laite : Esine
    {
        public string OS { get; set; }

        public Laite(double weight, double value, int acq)
            : base(weight,value,acq)
            {

            }

        public void PrintLaite()
        {
            Console.WriteLine("Laite:");
            Console.WriteLine("Weight: {0}, Value: {1}, Time of Acquisition: {2}, OS: {3}", Weight, Value, Acq, OS);
        }
    }
}
