namespace Cricket;

public class Game
{
    public class Game
    {
        public Player batsman;
        public Player bowler;
        public Random random;

        public Game(string batsmanName, string bowlerName)
        {
            batsman = new Player(batsmanName);
            bowler = new Player(bowlerName);
            random = new Random();
        }

        public void PlayRound()
        {
            Console.WriteLine($"{batsman.Name}, enter your score (0-6):");
            string batsmanInput = Console.ReadLine();

            int batsmanScore;
            bool isValidInput = int.TryParse(batsmanInput, out batsmanScore);

            if (!isValidInput || batsmanScore < 0 || batsmanScore > 6)
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and 6.");
                return;
            }

            int bowlerScore = random.Next(0, 7);
            Console.WriteLine($"{bowler.Name} bowled a {bowlerScore}");

            if (batsmanScore == bowlerScore)
            {
                Console.WriteLine("Batsman is out!");
                return;  
            }

            batsman.Score += batsmanScore;
            Console.WriteLine($"{batsman.Name}'s current score: {batsman.Score}");
        }
    }
}