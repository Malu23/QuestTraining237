using System;

namespace CreditCard
{

    internal class Program
    {
        static void Main()
        {
            var ccManager = new CreditCardManager();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var card = GetCardData();
                        ccManager.Add(card);
                        break;
                    case "2":
                        Console.Write("Enter the number to search: ");
                        var cardNumber = Console.ReadLine();
                        ccManager.Search(cardNumber);
                        break;
                }
            }
        }

        private static CreditCard GetCardData()
        {
            CreditCard card = new CreditCard();

            Console.Write("Enter the card holder name: ");
            card.CardHolderName = Console.ReadLine();

            Console.Write("Enter the card number: ");
            card.CardNumber = Console.ReadLine();

            Console.Write("Enter the card expiry date: ");
            card.Expiry = Console.ReadLine();

            Console.Write("Enter the security number: ");
            card.SecurityCode = int.Parse(Console.ReadLine());
            return card;
        }
    }
}