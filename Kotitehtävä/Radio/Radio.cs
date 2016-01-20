using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Radio
    {
        public bool IsOn { get; set; }
        private int volume;
        private double frequency;

        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume && value >= minVolume)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Volume out of bounds - no change.");
                }
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= maxFrequency && value >= minFrequency)
                {
                    frequency = value;
                }
                else
                {
                    Console.WriteLine("Frequency out of bounds - no change.");
                }
            }
        }

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

        public void PrintData()
        {
            Console.WriteLine("Radio:");
            Console.WriteLine("Is on: " + IsOn);
            Console.WriteLine("Volume: {0} Frequency {1}", Volume, Frequency);
        }

    }
}
