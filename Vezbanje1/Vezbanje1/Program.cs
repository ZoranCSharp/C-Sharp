using System;

namespace Vezbanje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            //asign value to array grades at index 0
            grades[0] = int.Parse(input);

            Console.WriteLine($"Grades at index 0: {grades[0]}");

            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine($"Length of gradesOfMayhStudentsA is: {gradesOfMathStudentsA.Length}" );

            int[] nums = new int[10];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            //for(int j = 0; j< nums.Length; j++)
            foreach (int k in nums)
            {
                Console.WriteLine($"Clan niza {k} = {nums[k]}");
            }
            Console.WriteLine("\n");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            string[] friends = new string[] { "Pera", "Mika", "Grok", "" ,""};
            friends.SetValue("Floki", 3);
            friends.SetValue("Himen", 4);

            int count = 0;
            foreach(string x in friends)
            {
                Console.WriteLine($"Friend number[{count}]: {x}");
                count++;
            }
            //declare 2d array
            string[,] matrix;

            //3d array
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, //row0
                {4,5,6}, //row1
                {7,8,9} //row2
            };

            Console.WriteLine($"Central value is {array2D[1,1]}");

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010","011" },
                    {"Hi there", "What's up?" }
                },

                {
                    {"100","101" },
                    {"110","111" },
                    {"Another one", "Last entry" }
                }
            };

            Console.WriteLine($"the value is: {array3D[0, 2, 0]}");

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two"},
                {"three", "four" },
                {"five", "six" }
            };

            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;

            Console.WriteLine($"The  value is: {array2DString[1,1]}");
            Console.WriteLine($"The dimensions is:  {dimensions}");

            int[,] array2D2 =
            {
                {1,2 },
                {3,4 }
            };
        }
    }
}
