using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.OnOff();
            radio.Volume = 4;
            radio.Frequency = 56000.0;
            radio.Frequency = 1300.0;
            radio.Frequency = 2400.0;
            radio.PrintData();
            Console.ReadLine();


        }
    }
}
