using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            {
                bool x = true;
                int y;
                while (x == true)
                {
                    Console.WriteLine("Anna kerros: ");
                    string line = Console.ReadLine();
                    x = int.TryParse(line, out y);
                    if (x == true)
                    {
                        hissi.Floor = y;
                    }
                    if (x == false)
                    {
                        break;
                    }
                }
            }

        }
    }
}
