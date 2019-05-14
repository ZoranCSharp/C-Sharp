using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje4
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIdInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIdInfo.IDNum} and is owned by {carIdInfo.Owner}");
        }
        public Car()
        {

        }

        public Car(int hp, string color)
        {
            this.Color = color;
            this.HP = hp;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"HP of this car is {HP} and its color is {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car Was repaired!");
        }
    }
}
