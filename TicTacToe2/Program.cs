using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] playfield =
        {
            {'1','2','3' }, //Row 0
            {'4','5','6' }, //Row 1
            {'7','8','9' }  //Row 2
        };


        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;


            //Run code as long as the program runs
            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                SetField();

                #region
                //Check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playfield[0, 0] == playerChar) && (playfield[0, 1] == playerChar) && (playfield[0, 2] == playerChar))
                        || ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar))
                        || ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 1] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 2] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar)))
                    {
                        if (playerChar == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPLAYER 2 HAS WON!!!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPLAYER 1  HAS WON!!!");
                        }

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPlease press any key to reset the game!");
                        Console.ReadKey();

                        ResetField();
                        break;


                    }
                    else if (turns == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nDRAW!!!");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPlease press any key to reset the game!");
                        Console.ReadKey();

                        ResetField();
                        break;
                    }
                }
                #endregion

                #region 
                //Test if field already taken
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"\nPlayer {player}: Choose your field! ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nPlease enter a number!!!");
                    }

                    if ((input == 1) && (playfield[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playfield[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playfield[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playfield[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playfield[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playfield[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playfield[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playfield[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playfield[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nIncorrect input! Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion


            } while (true);


        }

        public static void SetField()
        {
            Console.Clear();
            ConsoleColor a = Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n          |       |       ");
            Console.WriteLine($"      {playfield[0, 0]}   |   {playfield[0, 1]}   |   {playfield[0, 2]}   ");
            Console.WriteLine($"   _______|_______|______");
            Console.WriteLine($"          |       |    ");

            Console.WriteLine("          |       |       ");
            Console.WriteLine($"      {playfield[1, 0]}   |   {playfield[1, 1]}   |   {playfield[1, 2]}   ");
            Console.WriteLine($"   _______|_______|______");
            Console.WriteLine($"          |       |    ");

            Console.WriteLine("          |       |       ");
            Console.WriteLine($"      {playfield[2, 0]}   |   {playfield[2, 1]}   |   {playfield[2, 2]}   ");
            Console.WriteLine($"          |       |      ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n   Developed by Kiza V.1.0");
            turns++;

        }

        public static void ResetField()
        {
            char[,] playfieldInitial =
        {
            {'1','2','3' }, //Row 0
            {'4','5','6' }, //Row 1
            {'7','8','9' }  //Row 2
        };

            playfield = playfieldInitial;
            SetField(); //"turns" is here equals to 1
            turns = 1;
        }


        public static void EnterXorO(char playerSign, int input)
        {

            switch (input)
            {

                case 1: playfield[0, 0] = playerSign; break;
                case 2: playfield[0, 1] = playerSign; break;
                case 3: playfield[0, 2] = playerSign; break;
                case 4: playfield[1, 0] = playerSign; break;
                case 5: playfield[1, 1] = playerSign; break;
                case 6: playfield[1, 2] = playerSign; break;
                case 7: playfield[2, 0] = playerSign; break;
                case 8: playfield[2, 1] = playerSign; break;
                case 9: playfield[2, 2] = playerSign; break;

            }
        }
    }
}
