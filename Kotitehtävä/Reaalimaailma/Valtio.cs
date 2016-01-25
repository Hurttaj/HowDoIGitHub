using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaalimaailma
{
    class Valtio : Kunta
    {
        public string Hallitusmuoto;

        public Valtio(string name)
            :base(name)
        {
            
        }

        public void PrintValtio()
        {
            Console.WriteLine("Valtio:");
            Console.WriteLine("Name: {0}, Hallitusmuoto: {1}, Väkiluku: {2}, Alue: {3}, Korkein kohta: {4}", Name, Hallitusmuoto, People, Area, Height);
        }
    }
}
