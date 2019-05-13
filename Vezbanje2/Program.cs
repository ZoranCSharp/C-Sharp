using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine($"The Value in the middle of the first entry is {jaggedArray[0][2]}");

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine($"Element {i}");

                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine($"{jaggedArray[i][j]}");
                }
            }

            string[] joesFamily = new string[] { "Ana", "Bannana" };

            string[][] friendAndFamily = new string[][]
            {
                new string[] {"Michael", "Sandy"},
                new string[] {"Frank", "Claudia"},
                new string[] {"Andrew", "Michelle"},
                joesFamily
            };

            Console.WriteLine($"Hi {friendAndFamily[0][0]}, I would like to introduce {friendAndFamily[2][1]} to you. ");
            Console.WriteLine($"Hi {friendAndFamily[1][0]}, I would like to introduce {friendAndFamily[0][1]} to you. ");
            Console.WriteLine($"Hi {friendAndFamily[2][0]}, I would like to introduce {joesFamily[1]} to you. ");
           

            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine($"{grade}");
            }

            Console.WriteLine($"\nThe average is: {averageResult}");

            int[] happiness = { 2, 3, 4, 5, 6 };
            SunIsShining(happiness);

            foreach(int y in happiness)
            {
                Console.WriteLine(y);
            }

            //declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            //declaring an ArrayList with defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(258);
            myArrayList.Add(25.3);

            //delete element with specific value from the arraylist
            myArrayList.Remove(25.3);

            //delete element at specific position
            myArrayList.RemoveAt(3);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if(obj is double)
                {
                    sum += (double)obj;
                }else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;

            return average;
        }

        static void SunIsShining(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
            };
        }
    }
}
