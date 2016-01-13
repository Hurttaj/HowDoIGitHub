using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Taulu = new int[5];
            int x = 0;
            while (x<5)
            {
                Console.Write("Anna luku: ");
                Taulu[x] = int.Parse(Console.ReadLine());
                x++;
            }
            while (x>0)
            {
                Console.Write(Taulu[x-1] + ", ");
                x--;
            }
        }
    }
}
