using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunnes0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Luku = new int[50]; // Taulukko johon luvut menevät jotta ne voidaan laskea yhteen
            int X; // Muuttuja jolla do-while looppi katkaistaan.
            int Y = 0; // Laskuri joka talletta luvun oikeaan paikkaan.
            int Summa = 0; // Muuttuja johon summa talletetaan loopissa.

            do
            {
                Console.Write("Anna Luku: ");
                X = int.Parse(Console.ReadLine());
                Luku[Y] = X;
                Y++;
            }
            while (X != 0);
            while (Y != -1)
            {
                Summa = Summa + Luku[Y];
                Y--;
            }
            Console.WriteLine("Lukujen summa on " + Summa);
        }
    }
}
