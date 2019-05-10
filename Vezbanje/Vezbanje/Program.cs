using System;

namespace Vezbanje
{
    class Program
    {
        static int highScore = 300;
        static string highScorePlayer = "Zoran";       

    static void Main(string[] args)
        {
            //Members CLASS
            Members member1 = new Members();
            member1.Introduce(true);


            //Box CLASS
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Box box = new Box(5,10,20);          
            box.DisplayInfo();
            Console.WriteLine($"Front surface of the box is: {box.FrontSurface}");

            //Human CLASS
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            //create an object of my class
            //an instance of Human
            Human zoran = new Human("Zoran", "Kovacevic");

            //access public variable from outside, and even change it
            //zoran.firstName = "Zoran";
            //zoran.lastName = "Kovacevic";

            //call methods of the class
            zoran.IntroduceMyself();


            Human mika = new Human("Mika", "Mikic");
            //mika.firstName = "Mika";
            //mika.lastName = "Mikic";
            mika.IntroduceMyself();

            //Methods
            averageChallenge();
            challengeIfStatements(250, "Pera");
            challengeIfStatements(315, "Zoran");

            
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

            grok();
            breakContine();

        }

        //start methods
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

        public static void challengeIfStatements(int score, string name)
        {
            if(score > highScore)
            {
                highScore = score;
                highScorePlayer = name;

                Console.WriteLine($"New highscore is: {highScore}");
                Console.WriteLine($"It's held by {highScorePlayer}");

            }else
            {
                Console.WriteLine($"The old highscore is still not broken and it's held by {highScorePlayer} and score is {highScore}" + "\n");
            }
        }

        public static void grok()
        {
        
            int lengthOfText = 0;
            string wholeText = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            do
            {
                Console.WriteLine("Please enter the name of a friend: ");

                string nameOfAFriend = Console.ReadLine();

            int currentLength = nameOfAFriend.Length;
            lengthOfText += currentLength;
                wholeText += "\n" + nameOfAFriend + "\n";

            } while (lengthOfText< 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Thanks, that was enough!" + wholeText);

        }

        public static void breakContine()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if(counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }
           
        }


        public static void averageChallenge()
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"Last number was {currentNumber}");
                Console.WriteLine("Please enter the next score");
                Console.WriteLine($"Current amount of entries {count}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"Please enter -1 once you are rady to calculate the average");

                input = Console.ReadLine();

                if (input.Equals("-1"))
                {
                    Console.WriteLine("-------------------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine($"The average score of your students is {average}");
                }

                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }

                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("Please enter a value between 1 and 21");
                    }
                    continue;
                }

                count++;
            }
            Console.ReadLine();
        }

    }
}
