using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotain
{
    class Esine
    {
        public double Weight { get; set; }
        public double Value { get; set; }
        public int Acq { get; set; }

        public Esine(double weight, double value, int acq)
        {
            Weight = weight;
            Value = value;
            Acq = acq;
        }


        public void PrintData()
        {
            Console.WriteLine("Esine:");
            Console.WriteLine("Weight: {0}, Value {1}, Time of Acquisition {2}", Weight, Value, Acq);
        }



    }
}
