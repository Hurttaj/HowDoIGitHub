using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas
{
    class Kiuas
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        public void OnOff()
        {
            if (IsOn == true)
                {
                IsOn = false;
                }
            else
                {
                IsOn = true;
                }
        }

        public void IncreaseTemp()
        {
            Temperature += 5;
        }

        public void DecreaseTemp()
        {
            Temperature -= 5;
        }

        public void IncreaseHumid()
        {
            Humidity += 5;
        }

        public void DecreaseHumid()
        {
            Humidity -= 5;
        }


        public void PrintData()
        {
            Console.WriteLine("Heater data:");
            Console.WriteLine("Is on: " + IsOn);
            Console.WriteLine("Temperature: {0} Humidity {1}", Temperature, Humidity);
        }
        public override string ToString()
        {
            return "Temperature : " + Temperature + "Humidity : " + Humidity;
        }
    }

}
