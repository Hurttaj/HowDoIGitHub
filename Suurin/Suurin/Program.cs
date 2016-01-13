using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suurin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna Luku: ");
            int Luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna Luku: ");
            int Luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna Luku: ");
            int Luku3 = int.Parse(Console.ReadLine());
            if (Luku1 > Luku2 && Luku1 > Luku3)
            {
                Console.WriteLine("Suurin luku on " + Luku1);
            }
            else if (Luku2 > Luku1 && Luku2 > Luku3)
            {
                Console.WriteLine("Suurin luku on " + Luku2);
            }
            else if (Luku3 > Luku1 && Luku3 > Luku1)
            {
                Console.WriteLine("Suurin luku on " + Luku3);
            }
        }
    }
}
