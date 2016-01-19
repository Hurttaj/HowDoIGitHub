using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle truck = new Vehicle();
            truck.Name = "Sisu";
            truck.Speed = 50;
            truck.Tyres = 30;

            truck.PrintData();
            Console.ReadLine();
            truck.Speed = 60;
            Console.WriteLine(truck.ToString());
            Console.ReadLine();
        }
    }
}
