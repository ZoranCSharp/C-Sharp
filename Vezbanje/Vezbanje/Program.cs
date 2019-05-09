using System;

namespace Vezbanje
{
    class Program
    {
        static void Main(string[] args)
        {


            bool isAdmin = false;
            bool isRegistered = true;
            string username = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Please enter your username: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            username = Console.ReadLine().ToLower();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;

            if (isRegistered && username != "" && username.Equals("admin"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Hi there, registered user!");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Hi there, " + username);

            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in" + "\n");
            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            //Console.Clear();

            /*
            string name = "Name";
            string name2 = name.ToUpper();
            string name3 = name.ToLower();

            
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"Hello {name2}!");
            Console.WriteLine($"Hello {name3}!");
            */

            /*
            string unos = Console.ReadLine();
            Console.WriteLine(unos);
            
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num);
            */
            Console.WriteLine("Please enter number: ");
            string number = Console.ReadLine();
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                int newNumber = Int32.Parse(number);

            } catch (FormatException e)
            {
                Console.WriteLine("\n" + e);
                Console.WriteLine("\n" + "Please enter number!" + "\n");
            } catch (OverflowException e1)
            {
                Console.WriteLine("\n" + e1);
                Console.WriteLine("\n" + "Please enter shorter number!" + "\n");
            } catch (ArgumentNullException e2)
            {
                Console.WriteLine("\n" + e2);
                Console.WriteLine("\n" + "Please enter number!" + "\n");
            }
            finally
            {
                Console.WriteLine("\n" + "This is called anyways!!!" + "\n");
            }

            int num1 = 0;
            int num2 = 10;
            int result;

            try
            {
                result = num2 / num1;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n" + e);
            }

            int numb2;
            string numb1 = "10";

            bool provera = int.TryParse(numb1, out numb2);

            Console.WriteLine(provera);

            const string birthday = "01.01.2019.";
            Console.WriteLine($"My birthday will be: {birthday}");

            methodFirst();
            methodSecond("ProbaProbaProba");
            Console.WriteLine(addNumber(2, 3));

        }

        public static void methodFirst()
        {
            Console.WriteLine("First method");
        }

        private static void methodSecond(string mytext)
        {
            Console.WriteLine(mytext);
        }

        public static int addNumber(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
