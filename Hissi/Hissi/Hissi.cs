using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Hissi
    {
        private int floor;

        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        public int Floor
        {
            get
            {
                return floor;

            }
            set
            {
                if (value <= maxFloor && value >= minFloor)
                {
                    floor = value;
                    Console.WriteLine("Hissi on kerroksessa " + value);
                }
                else
                {
                    Console.WriteLine("Näätkö jossain " + value + " napin. On kyllä aika velho kun menee olemattomiin kerroksiin.");
                }
            }
        }
        
        }
}
