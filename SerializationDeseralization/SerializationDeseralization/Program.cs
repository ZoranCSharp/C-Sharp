using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializationDeseralization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");

            //ANIMAL-------------------------------------------------------------------------------------------------------------------

            Animal animal = new Animal("Zoran", 110, 180, 1, new Employee("Big", "Boss", DateTime.Parse("2019-12-30")));

            animal.Weight = 120;
            animal.Name = "Zoran";
            animal.Height = 200;
            animal.AnimalID = 1;

            //Serializable the object data to file
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);

            //XmlSerializer writes object data to XML
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\zoran.kovacevic\Desktop\SerializationDeseralization\stream.xml"))
            {
                xmlSerializer.Serialize(tw, animal);
            }

            //Delete stream data
            stream = null;

            //Deserialize from XML to the object
            XmlSerializer deserialize = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\zoran.kovacevic\Desktop\SerializationDeseralization\stream.xml");

            object obj = deserialize.Deserialize(reader);
            animal = (Animal)obj;
            reader.Close();

            Console.WriteLine(animal.ToString());

            //ANIMALS LIST-------------------------------------------------------------------------------------------------------------
            List<Animal> animalList = new List<Animal>()
            {
                new Animal("Nenad", 120, 200, 2, new Employee("Civ", "Vava", DateTime.Parse("2019-12-30"))),
                new Animal("Milorad", 220, 300, 3, new Employee("Grok", "Grokic", DateTime.Parse("2019-12-30"))),
                new Animal("Misojcic", 300, 500, 4,new Employee("Slon", "Slonovski", DateTime.Parse("2019-12-30")))
            };

            using (Stream fileStream = new FileStream(@"C:\Users\zoran.kovacevic\Desktop\SerializationDeseralization\animals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer newXMLSerializer = new XmlSerializer(typeof(List<Animal>));
                newXMLSerializer.Serialize(fileStream, animalList);
            }

            //Delete animalList data
            animalList = null;

            //DESERIALIZE ANIMALS LIST

            using (FileStream fs = File.OpenRead(@"C:\Users\zoran.kovacevic\Desktop\SerializationDeseralization\animals.xml"))
            {
                XmlSerializer xmlListSerializer = new XmlSerializer(typeof(List<Animal>));
                animalList = (List<Animal>)xmlListSerializer.Deserialize(fs);
            }

            foreach (Animal animals in animalList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(animals.ToString());
            }
            //-------------------------------------------------------------------------------------------------------------------------

            //EMPLOYEE

            Employee employee = new Employee();
            employee.Name = "zoran";
            employee.LastName = "kovacevic";
            employee.DOB = DateTime.Parse("2019-12-20");
            employee.Save("heybabe.xml");


            //Deserialize Employee
            Employee employeeDeserializer = Employee.LoadFromFile("HeyBabe.xml");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Name: {employeeDeserializer.Name}\n" + $"LastName: {employeeDeserializer.LastName}\n" + $"Date of Birth: {employeeDeserializer.DOB.ToShortDateString()}");

            //LIST EMPLOYEE------------------------------------------------------------------------------------------------------------
            List<Employee> listEmployee = new List<Employee>()
            {
                new Employee("Nenad", "Krantic", DateTime.Parse("2019-12-30")),
                new Employee("Marko", "Misojcic", DateTime.Parse("2018-12-15")),
                new Employee("Milos", "Obilic", DateTime.Parse("2100-12-15")),
                new Employee("Kruska", "Kruskic", DateTime.Parse("2090-11-20")),
                new Employee("Ruska", "Ruzic", DateTime.Parse("2012-9-17")),
                new Employee("Pera", "Peric", DateTime.Parse("2015-5-20")),
            };

            //SERIALIZE LIST
            using (Stream fileStream = new FileStream(@"C:\Users\zoran.kovacevic\Desktop\SerializationDeseralization\listEmployee.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer newXMLSerializer = new XmlSerializer(typeof(List<Employee>));
                newXMLSerializer.Serialize(fileStream, listEmployee);
            }
            //DELETE EMPLOYEE LIST DATA
            listEmployee = null;

            //DESERIALIZE EMPLOYEE LIST
            using (FileStream fs = File.OpenRead(@"C:\Users\zoran.kovacevic\Desktop\SerializationDeseralization\listEmployee.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                listEmployee = (List<Employee>)serializer.Deserialize(fs);
            }

            foreach (Employee employees in listEmployee)
            {
                Console.WriteLine(employees.ToString());
            }


            Console.ReadKey();
        }



    }
}
