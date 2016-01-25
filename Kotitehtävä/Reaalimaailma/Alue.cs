using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaalimaailma
{
    class Alue
    {
        private double area;
        private readonly double minArea = 0;
        public double Height { get; set; }

        public double Area
        {
            get
            {
                return area;

            }
            set
            {
                if (value >= minArea)
                {
                    area = value;
                }
                else
                {
                    Console.WriteLine("Jees homma, negatiivinen maa-alue.");
                }
            }
        }

    }

}
