using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp
{

    enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec};
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine($"Game 1's name is: {name}");
            Console.WriteLine($"Game 1's is developed: {developer}");
            Console.WriteLine($"Game 1's rating is: {rating}");
            Console.WriteLine($"Game 1's was released in: {releaseDate}");
            Console.ReadLine();
        }
    }
    class Program
    {
        //delegate
        public delegate int SomeMath(int i);
        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {
            DoSomething();
            

            ListsArrayListsArrays();
            Console.ReadLine();

            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            //Console.WriteLine($"Game 1's name is: {game1.name}");
            //Console.WriteLine($"Game 1's is developed: {game1.developer}");
            //Console.WriteLine($"Game 1's rating is: {game1.rating}");
            //Console.WriteLine($"Game 1's was released in: {game1.releaseDate}");
            //Console.ReadLine();

            game1.Display();

            Day fr = Day.Fr;
            Day su = Day.Su;
            Day a = Day.Fr;

            Console.WriteLine(fr == a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.Jan);

            Console.WriteLine("Ceilling: " + Math.Ceiling(15.3));
            Console.WriteLine("Flooring: " + Math.Floor(15.3));

            int num1 = 14;
            int num2 = 9;
            Console.WriteLine($"Lower of num1 {num1} and num2 {num2} is {Math.Min(num1, num2)}");
            Console.WriteLine($"Higher of num1 {num1} and num2 {num2} is {Math.Max(num1, num2)}");
            Console.WriteLine($"Math PI is: {Math.PI}");
            Console.WriteLine($"cos of 1 is: {Math.Cos(1)}");

            Random dice = new Random();
            int numEyes;
            for(int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1,7);
                Console.WriteLine(numEyes);
            }

            Random yesNoMaybe = new Random();

            Console.WriteLine("Please enter you question!");
            Console.ReadLine();
            int answerNum;
            answerNum = yesNoMaybe.Next(1, 4);

            if(answerNum == 1)
            {
                Console.WriteLine("Yes");
            }else if(answerNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();


        }

        public static void DoSomething()
        {
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(8));

            List<int> list = new List<int> { 1,2,3,4,5,6,7};
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            foreach(int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            List<int> oddNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 != 0);
            });

            foreach(int i in oddNumbers)
            {
                Console.WriteLine(i);
            }

            List<int> oddNumbers2 = list.FindAll(i => i % 2 == 1);
            oddNumbers2.ForEach(i => Console.WriteLine(i));

            math = new SomeMath(x => x * x);
            Console.WriteLine(math(8));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(6,new Number {n = 5 }));
        }

          
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Square(int i)
        {
            return i * i;
        }

        public static int TimesTen(int i)
        {
            return i * 10;
        }

        public static void ListsArrayListsArrays()
        {
            //imutable - limited to one type
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            list.Add(0);
            list.Add(32);
            list.Sort();
            list.RemoveRange(2, 2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);
            list.ForEach(i => Console.WriteLine(i));

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });

            foreach(Object o in arrayList)
            {
                Console.WriteLine(o);
            }

        }
    }
}
