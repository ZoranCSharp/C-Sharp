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
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            OddNumbers(number);
            Console.ReadKey();
        }

        static void OddNumbers(int[] numbers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Odd Number: ");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers+"\n");
            
            foreach(int i in oddNumbers)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(i);
            }
        }
    }
}
