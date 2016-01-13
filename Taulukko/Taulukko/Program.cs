using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Luvut = new int[9];
            Luvut[0] = 1;
            Luvut[1] = 2;
            Luvut[2] = 33;
            Luvut[3] = 44;
            Luvut[4] = 55;
            Luvut[5] = 68;
            Luvut[6] = 77;
            Luvut[7] = 96;
            Luvut[8] = 100;
            int Y = 0;
            while (Y < 9)
            {
                if (Luvut[Y] % 2==0)
                {
                    Console.WriteLine("HEP!");
                }
                Y++;
                Console.ReadLine();
            }

        }
    }
}
