using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter the number of points to win: ");
            int winningScore = int.Parse(Console.ReadLine());

            Game game = new Game(userName, winningScore);

            while (!game.IsGameOver())
            {
                game.PlayRound();
            }

            game.DeclareWinner();
        }
    }
}