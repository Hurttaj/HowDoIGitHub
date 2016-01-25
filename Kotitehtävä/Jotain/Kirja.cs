using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotain
{
    class Kirja : Esine
    {
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }

        public Kirja(double weight, double value, int acq, int pagecount)
            : base(weight,value,acq)
        {
            PageCount = pagecount;
        }

         public void PrintKirja()
        {
            Console.WriteLine("Kirja:");
            Console.WriteLine("Weight: {0}, Value: {1}, Time of Acquisition: {2}, Page Count: {3}, Author: {4}", Weight, Value, Acq, PageCount, Author);
        }
    }
}
