using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace SerializationDeseralization
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime DOB { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string lastName, DateTime dob)
        {
            Name = name;
            LastName = lastName;
            DOB = dob;
        }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(Employee));
                XML.Serialize(stream, this);

            }
        }

        public static Employee LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer XMLDeserializer = new XmlSerializer(typeof(Employee));
                return (Employee)XMLDeserializer.Deserialize(stream);
            }
        }

        public override string ToString()
        {
            return string.Format($"Employee: {Name} was born {DOB.ToShortDateString()}");
        }

        //public Employee(SerializationInfo info)
        //  {
        //      Name = (string)info.GetValue("Name", typeof(string));
        //      LastName = (string)info.GetValue("LastName", typeof(string));
        //      DOB = (DateTime)info.GetValue("DOB", typeof(DateTime));
        //  }

    }
}
