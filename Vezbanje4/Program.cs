using System;
using System.Collections.Generic;
using System.IO;
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
            // Method 1
            string[] lines2 = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"C:\Users\zoran.kovacevic\Desktop\Vezbanje4\highscores.txt", lines2);

            // Method 2
            Console.WriteLine("Please give the file a name");            
            string fileNames = Console.ReadLine();
            Console.WriteLine("Please anter the text for the file");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\zoran.kovacevic\Desktop\Vezbanje4\" + fileNames + ".txt", input);

            // Method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\zoran.kovacevic\Desktop\Vezbanje4\method3.txt"))
            {
                foreach (var line in lines2)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Example 1 - reading Text
            string text = System.IO.File.ReadAllText(@"C:\Users\zoran.kovacevic\Desktop\Vezbanje4\textFile.txt");
            Console.WriteLine($"Textfile contains following text: {text}");

            // Example 2 - reading lines of text
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\zoran.kovacevic\Desktop\Vezbanje4\textFile.txt");
            Console.WriteLine($"Contents of textFile.txt = ");

            foreach(string line in lines)
            {
                Console.WriteLine("\t"+ line);
            }
            Console.ReadKey();

        }
    }
}
