using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Book
    {

        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Book:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("PageCount: " + PageCount);
        }
        public void IncreaseCount()
        {
            PageCount += 5;
        }

        public void DecreaseCount()
        {
            PageCount -= 5;
        }

        public void NameChange()
        {
            Console.WriteLine("Anna uusi nimi:");
            Name = Console.ReadLine();
        }

    }
}