using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje4
{
    //AUDI is a Car
    class AUDI:Car
    {
        private string brand;
        public string Model { get; set; }

        public AUDI()
        {

        }

        public AUDI(string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
                    }

        public new void ShowDetails()
        {
            Console.WriteLine($"HP of {brand} is {HP} and its color is {Color}");
        }

        public override void Repair()
        {
            Console.WriteLine("Car is repaired on 12.11.2019.!");
        }
    }
}
