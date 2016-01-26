using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotain
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirja kirja = new Kirja(0.4, 20, 2010, 807);
            kirja.Author = "GRRM";
            kirja.Name = "Game of Thrones";
            kirja.PrintKirja();

            Laite kannettava = new Laite(1.0, 800, 2014);
            kannettava.OS = "Windows 8";
            kannettava.PrintLaite();
       

        }
    }
}
