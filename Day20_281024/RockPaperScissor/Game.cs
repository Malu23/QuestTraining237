using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Game
    {
        public Player user;
        public Player computer;
        public Random random;
        public int winningScore;

        private string[] validChoices = { "rock", "paper", "scissors" }; 

        public Game(string userName, int winningScore)
        {
            user = new Player(userName);
            computer = new Player("Computer");
            random = new Random();
            this.winningScore = winningScore;
        }

        private string GetComputerChoice()
        {
            int randomIndex = random.Next(0, validChoices.Length);  
            return validChoices[randomIndex];
        }

        public void PlayRound()
        {
            Console.WriteLine("\nEnter your choice (1 for Rock, 2 for Paper, 3 for Scissors):");
            string userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("Invalid choice, please try again.");
                return;
            }

            // Convert user input to choice.
            string userChoice = validChoices[int.Parse(userInput) - 1]; 
            string computerChoice = GetComputerChoice();

            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win this round!");
                user.Score++;
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computer.Score++;
            }

            Console.WriteLine($"Score - {user.Name}: {user.Score}, Computer: {computer.Score}");
        }

        public bool IsGameOver()
        {
            return user.Score >= winningScore || computer.Score >= winningScore;
        }

        public void DeclareWinner()
        {
            if (user.Score > computer.Score)
            {
                Console.WriteLine($"\nCongratulations, {user.Name}! You won the game!");
            }
            else
            {
                Console.WriteLine("\nComputer wins the game. Better luck next time!");
            }
        }
    }
}
