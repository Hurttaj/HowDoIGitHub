using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Proletariat> proles = new List<Proletariat>();
            Proletariat prole = new Proletariat();
            prole.FirstName = "Ernst";
            prole.LastName = "Busch";
            Console.WriteLine(prole.Agitate());
            prole.IsRevolutionary = true;
        }
    }
}
