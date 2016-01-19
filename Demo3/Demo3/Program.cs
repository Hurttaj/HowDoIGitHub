using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car trabant = new Car(); // create Car object
            trabant.Model = "Trabant";
            trabant.Color = "Musta";
            trabant.Speed = 30;
            trabant.Engine = 0.5;
            trabant.FuzzyDice = false;

            Car nascar = new Car("Toyota");
            nascar.Speed = 200;
            nascar.Color = "Sininen";
            nascar.Engine = 9001.5;

            trabant.Accelerate(5);
            nascar.PrintData();
            trabant.PrintData();
            

            Console.ReadLine();
        
            
        }
    }
}
