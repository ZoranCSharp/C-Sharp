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

        }
    }
}
