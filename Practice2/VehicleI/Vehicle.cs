using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.VehicleI
{
    public class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Starting Engine!\n");
        }
    }
}
