using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.VehicleI
{
    public class Car :
        Vehicle
    {

        public bool IsElectric { get; set; }
        public string FuelType { get; set; }

        public Car(string make, string model, int year, bool isElectric, string fuelType) :
            base(make, model, year)
        {
            IsElectric = isElectric;
            IsElectric = isElectric;
            FuelType = fuelType;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.Write($"The Car is {(IsElectric ? "Electric" : "not Electrict")} ");
            Console.Write($",The Car is fueled by {FuelType}\n");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Staring the Car Engine for {base.Model}!\n");
        }

    }
}
