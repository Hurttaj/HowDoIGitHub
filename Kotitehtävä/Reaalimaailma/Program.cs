using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaalimaailma
{
    class Program
    {
        static void Main(string[] args)
        {
            Valtio Suomi = new Valtio("Suomi");
            Console.WriteLine("Anna hallitusmuoto: ");
            string line = Console.ReadLine();
            Suomi.Hallitusmuoto = line;

            Suomi.PrintValtio();

        }
    }
}
