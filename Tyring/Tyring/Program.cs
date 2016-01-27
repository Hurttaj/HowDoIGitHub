using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyring
{
    class Program
    {
        static void Main(string[] args)
        {
            Tyre nokia = new Tyre { Name = "Blorp", Model = "Erhmergerd", Size = "Derp16"};

            Vehicle car = new Vehicle();
            car.AddTyre(nokia);
            car.AddTyre(nokia);
            car.AddTyre(nokia);
            car.AddTyre(nokia);
            car.Name = "PoS";
            car.Model = "Trabant";

            Console.WriteLine(car.ToString()); //Miks tää ei toimidsfgfdgdf 
            

        }
    }
}
