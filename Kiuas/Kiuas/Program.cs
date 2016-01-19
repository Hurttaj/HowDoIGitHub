using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas heater = new Kiuas();
            heater.IsOn = true;
            heater.Temperature = 100;
            heater.Humidity = 95;
            heater.PrintData();

            Console.ReadLine();

            heater.DecreaseHumid();
            heater.DecreaseTemp();
            heater.OnOff();
            heater.PrintData();

            Console.ReadLine();
        }
    }
}
