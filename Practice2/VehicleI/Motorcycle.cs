using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.VehicleI
{
    public class Motorcycle : Vehicle
    {
        public string Type { get; set; }
        public bool HasHasWindShield { get; set; }

        public Motorcycle(string make, string model, int year, string type, bool hasWindShield)
            : base(make, model, year)
        {
            Type = type;
            HasHasWindShield = hasWindShield;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.Write($"The Motorcycle is type {Type} ");
            Console.Write($",The Motorcycle {(HasHasWindShield ? "has" : "doens't have")} a WindShield\n");
        }
    }
}
