using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Vezbanje
{
    class Members
    {
        //member private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member public field
        public int age;

        //member property - properties strart with a capital letter
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }

        //publoic memeber Method - can be called from other classes
        public void Introduce(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName} and my job is {jobTitle}. I'm {age} old");
            }

        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is: {salary}");
        }

        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members object!");
            Debug.Write("Destruction of Members object!!!");
        }
    }
}
