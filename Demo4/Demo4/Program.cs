using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 9001;
            Console.WriteLine("car speed is " + car.Speed);
            Console.ReadLine();
        }
    }
}
