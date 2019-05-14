using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje4
{
    class Program
    {
        static void Main(string[] args)
        {

            BMW bmw = new BMW("brmbrm100", 2000, "White");
            Console.WriteLine($"Model of this car  is {bmw.Model}\n");
            bmw.ShowDetails();
            bmw.Repair();

            AUDI audi = new AUDI("audi1", 2100, "Red");
            Console.WriteLine($"Model of this car  is {audi.Model}\n");
            audi.ShowDetails();
            audi.Repair();
            Console.WriteLine("\n");

            var cars = new List<Car>
            {
                new AUDI("audi1", 2100, "Red"),
                new BMW("brmbrm100", 2000, "White")
            };

            foreach(var  car in cars)
            {                
                car.Repair();
                
            }

            Car car1 = new Car(300, "Black");
            car1.ShowDetails();
            car1.Repair();

            M3 m3 = new M3("M3 Super Turbo", 200, "red");
            m3.Repair();

            bmw.SetCarIDInfo(32546, "Zoran Kovacevic");
            bmw.GetCarIDInfo();
            audi.SetCarIDInfo(25465, "Zoran Kovacevic");
            audi.GetCarIDInfo();

            Console.ReadLine();


        }
    }
}
