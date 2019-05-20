using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //OddNumbers(number);

            UniversityMenager univer = new UniversityMenager();
            Console.ForegroundColor = ConsoleColor.Green;
            univer.MalesStudents();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            univer.FemaleStudents();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            univer.SortStudentByAge();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Red;
            univer.allStudentFromBeijingTech();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter University Id: ");
            //int uniId = Int32.Parse(Console.ReadLine());

            bool test = true;
           
                do
                {
                    string input = Console.ReadLine();
                    try
                    {

                        int uniId = Convert.ToInt32(input);
                        univer.AllStudentsFromThatUni(uniId);


                    }
                    catch (Exception)
                    {
                    if (input == "exit")
                        break;
                    Console.WriteLine("Wrong Value");
                        test = false;
                   
                    }
                } while (test == false);

            int[] someInt = { 30, 125, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInt orderby i select i;
            IEnumerable<int> reverseInts = sortedInts.Reverse();

            foreach (int i in reverseInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSordetInts = from i in someInt orderby i descending select i;
            foreach (int i in reversedSordetInts)
            {
                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            univer.StudentAndUniversityNameCollection();


            Console.WriteLine("\n");
            //We simply  apply our Student-Structure to XML
            string studentsXML =
                @"<Students>
                    <Student>
                      <Name>Zoran</Name>
                      <Age>21</Age>
                      <University>Yale</University>
                      <Semester>First</Semester>
                    </Student>
                    <Student>
                      <Name>Ime1</Name>
                      <Age>17</Age>
                      <University>Yale</University>
                      <Semester>Second</Semester>
                    </Student>
                    <Student>
                      <Name>Ime2</Name>
                      <Age>27</Age>
                      <University>Yale</University>
                      <Semester>Third</Semester>
                    </Student>
                    <Student>
                      <Name>Ime3</Name>
                      <Age>27</Age>
                      <University>Yale</University>
                      <Semester>First</Semester>
                    </Student>
                  </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var studentsX = from student in studentsXdoc.Descendants("Student")
                            select new
                            {
                                Name = student.Element("Name").Value,
                                Age = student.Element("Age").Value,
                                University = student.Element("University").Value,
                                Semester = student.Element("Semester").Value

                            };

            foreach (var student in studentsX)
            {
                Console.WriteLine($"Student {student.Name} with  age {student.Age} from {student.University} University. Semester - {student.Semester}");
            }
            Console.WriteLine("\n");

            var sortedStudents = from stud in studentsX
                                 orderby stud.Age
                                 select stud;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Student {student.Name} with  age {student.Age} from {student.University} University. Semester - {student.Semester}");
            }

            Console.ReadLine();
        }

        //static void OddNumbers(int[] numbers)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine($"Odd Number: ");

        //    IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

        //    Console.WriteLine(oddNumbers+"\n");

        //    foreach(int i in oddNumbers)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Magenta;
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
