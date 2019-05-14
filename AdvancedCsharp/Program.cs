using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp
{
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
