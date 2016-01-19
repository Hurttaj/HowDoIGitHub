using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public double Engine { get; set; }
        public bool FuzzyDice { get; set; }

        // constructor
        public Car()
        {
            FuzzyDice = true;
        }

        // parametric constructor
        public Car(string model)
        {
            Model = model;
        }

        public void PrintData() // method displays car data
        {
            Console.WriteLine("Car data:");
            Console.WriteLine("- Model: " + Model);
            Console.WriteLine("- Color: " + Color);
            Console.WriteLine("- Engine: " + Engine);
            Console.WriteLine("- Speed: " + Speed);
            Console.WriteLine("- FuzzyDice: " + FuzzyDice);

        }

        // method gives more speed
        public void Accelerate(int newSpeed)
        {
            Speed += newSpeed;
        }
    }
}
