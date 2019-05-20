using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class UniversityMenager
    {
        public List<University> universities;
        public List<Student> student;

        //constructor
        public UniversityMenager()
        {
            universities = new List<University>();
            student = new List<Student>();

            //Lets add some Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Let's add  some Students
            student.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            student.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            student.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            student.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 34, UniversityId = 2 });
            student.Add(new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            student.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MalesStudents()
        {
            IEnumerable<Student> maleStudents = from stud in student where stud.Gender == "male" select stud;
            Console.WriteLine("Male Students: ");

            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from stud in student where stud.Gender == "female" select stud;
            Console.WriteLine("Female Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
    }
}
