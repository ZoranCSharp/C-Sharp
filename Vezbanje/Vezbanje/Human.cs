using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbanje
{
    //this class is a blueprint for a datatype
    class Human
    {
        //member  variable
        private string firstName;
        private string lastName;

        //member
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {firstName}" + "\n");
        }

        //Constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
