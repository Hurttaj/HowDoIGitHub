using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Kirja = new Book();
            Kirja.PageCount = 200;
            Kirja.Name = "Mars";
            Kirja.Author = "Ben Bova";
            Kirja.Genre = "Sci-Fi";

            Kirja.PrintData();
            Kirja.DecreaseCount();
            Kirja.NameChange();
            Kirja.PrintData();

        }
    }
}
