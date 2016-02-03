using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x;
            int count;
            Console.WriteLine("Anna heittojen määrä");
            string line = Console.ReadLine();
            x = int.TryParse(line, out count);

            double total = 0;

            int loop = 0;
            Random rand = new Random();
            Noppa noppa = new Noppa();   
            while (loop < count)
                {
                
                int perkele = noppa.Roll(rand);
                total += perkele;
                loop++;
                }
                Console.WriteLine(total);
                Console.WriteLine(total / count);
        }
    }
}
