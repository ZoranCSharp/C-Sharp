using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje4
{
    //a BMW is a Car
    class BMW:Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW()
        {

        }

        public BMW(string model, int hp, string color):base(hp, color)
        {
            this.Model = model;
         
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"HP of {brand} is {HP} and its color is {Color}");
        }

        public sealed override void Repair()
        {
            Console.WriteLine("BMW Was repaired!");
        }
    }
}
