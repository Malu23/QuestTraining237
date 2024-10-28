using System;
using System.Collections.Generic;
using System.Text;

namespace Cricket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter batsman's name: ");
            string batsmanName = Console.ReadLine();

            Console.Write("Enter bowler's name: ");
            string bowlerName = Console.ReadLine();

            Game game = new Game(batsmanName, bowlerName);

            // Continue playing until the batsman gets out.
            while (true)
            {
                game.PlayRound();
                if (game.batsman.Score == -1) 
                    break;
            }

            Console.WriteLine($"Game Over! {batsmanName}'s final score: {game.batsman.Score}");
        }
    }
}