using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje3
{
    class Boss:Employee
    {
        public string CompanyCar { get; set; }


        public Boss(string companyCar, string name, string firstName, int salary):base(name,firstName,salary)
        {
            this.CompanyCar = companyCar;            

        }
        public void Lead()
        {
            Console.WriteLine($"I'm Boss! My name is {FirstName} {Name}");
        }
    }
}
