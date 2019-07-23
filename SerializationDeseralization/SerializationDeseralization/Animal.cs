using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationDeseralization
{
    [Serializable]
    public class Animal : ISerializable
    {

        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public int AnimalID { get; set; }

        public Employee Eemployee { get; set; } //Setter Dependency injection

        public Animal()
        {

        }

        public override string ToString()
        {
            return string.Format($"{AnimalID}#: This Animal's name is: {Name} and it's height is: {Height} and it's weight is:{Weight}." + 
                                 $"His Master is: {Eemployee.Name} {Eemployee.LastName}" + " " + $" and he was born: {Eemployee.DOB.ToShortDateString()}.");
        }


        public Animal(string name, double height, double weight, int animalId, Employee employee) //Constructor Dependency injection
        {
            Name = name;
            Height = height;
            Weight = weight;
            AnimalID = animalId;
            Eemployee = employee;
        }

        //Serialization function (Stores Object Data in File)
        //SerializationInfo holds the key value pairs
        //StreamingContext can hold additional info but we are not using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimalID", AnimalID);
            info.AddValue("Employee", Eemployee);
        }

        //The deserialize function (Removes Object Data from File)
        public Animal(SerializationInfo info, StreamingContext context)
        {
            //Get the values from info and asign them to the properties
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
            AnimalID = (int)info.GetValue("AnimalID", typeof(int));
            Eemployee = (Employee)info.GetValue("Eemployee", typeof(Employee));
        }


    }
}
