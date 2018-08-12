using System;

namespace Game_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int computerplayer = 0;

            int playerone = 0;


            Console.WriteLine("play a game");

            Console.WriteLine("if you  Get To 20 First, you win");

            Console.Write("Please enter a name and hit enter: ");

            var playerName = Console.ReadLine();

            do
            {
                computerplayer += RollDice();

                Console.WriteLine("Player: " + computerplayer);

                computerplayer += RollDice();
                Console.WriteLine("Player: " + playerone);

            } while (playerone <= 20 && computerplayer <= 20);
            if (computerplayer >= 20)
            {
                Console.WriteLine("you win");
            }
            else if (playerone >= 20)
            {
                Console.WriteLine("you win");
            }
            else
            {

                Console.WriteLine("BLANK");
            }
            Console.ReadLine();
        }

        private static int RollDice()
        {
            Random rnd = new Random();

            return rnd.Next(1, 6);
        }
    }
}
    

