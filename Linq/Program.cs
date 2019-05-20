using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
