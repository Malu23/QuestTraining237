using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardSystem
{
    
    internal class Program
    {
        public static List<CreditCard> cards = new List<CreditCard>();
        
        static void AddCard()
        {
            Console.WriteLine("Enter the card number: ");
            var cardNumber = Console.ReadLine();
            
            Console.WriteLine("Enter the card holder name: ");
            var holderName = Console.ReadLine();

            Console.WriteLine("Enter the expiry date in MM/YY format: ");
            var expiry = Console.ReadLine();

            Console.WriteLine("Enter the Security code: ");
            var securityCode = Console.ReadLine();
            
            var newCard = new CreditCard()
            {
                CardNumber = int.Parse(cardNumber),
                HolderName = holderName,
                ExpiryMonth = byte.Parse(expiry.Split('/')[0]),
                ExpiryYear = byte.Parse(expiry.Split('/')[1]),
                Cvc = int.Parse(securityCode)
            };
            
            cards.Add(newCard);
            Console.WriteLine($"Card {cardNumber} for {holderName} has been added successfully");
        }
    
        static void UpdateCard()
        {
            Console.WriteLine("Enter the card number: ");
            var cardNumber = int.Parse(Console.ReadLine());
            
            CreditCard cardToUpdate = null;
            foreach (var card in cards)
            {
                if (card.CardNumber == cardNumber)
                {
                    cardToUpdate = card;
                    break;
                }
            }
              
            if (cardToUpdate != null)
            {
                Console.WriteLine("1. Update card holder name");
                Console.WriteLine("2. Update Cvc");
                Console.WriteLine("3. Exit");
                var choice = Console.ReadLine();
            
                if(choice == "1")
                {
                    Console.WriteLine("Enter the new name: ");
                    var newName = Console.ReadLine();
                    cardToUpdate.HolderName = newName;
                    Console.WriteLine($"The card holder name for card {cardNumber} has been updated.");
                }
                else if(choice == "2")
                {
                    Console.WriteLine("Enter the new Cvc: ");
                    var newCvc = Console.ReadLine();
                    cardToUpdate.HolderName = newCvc;
                    Console.WriteLine($"The Cvc for card {cardNumber} has been updated.");
                }
            }
            else
            {
                Console.WriteLine("Card not found. Try again!");
            }
        }
            
        static void DeleteCard()
        {
            Console.WriteLine("Enter the card number to delete: ");
            var cardNumber = int.Parse(Console.ReadLine());

            CreditCard cardToDelete = null;
            foreach (var card in cards)
            {
                if (card.CardNumber == cardNumber)
                {
                    cardToDelete = card;
                    break;
                }
            }

            if (cardToDelete != null)
            {
                cards.Remove(cardToDelete);
                Console.WriteLine($"The card {cardNumber} has been deleted successfully.");
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
        
        static void SearchCard()
        {
            Console.WriteLine("Enter the card number to search: ");
            var cardNumber = int.Parse(Console.ReadLine());

            CreditCard foundCard = null;
            foreach (var card in cards)
            {
                if (card.CardNumber == cardNumber)
                {
                    foundCard = card;
                    break;
                }
            }

            if (foundCard != null)
            {
                Console.WriteLine(foundCard);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add a new card");
                Console.WriteLine("2. Update an existing card");
                Console.WriteLine("3. Delete a card");
                Console.WriteLine("4. Search a card");
                Console.WriteLine("5. Exit");
                
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddCard();
                        break;
                    case "2":
                        UpdateCard();
                        break;
                    case "3":
                        DeleteCard();
                        break;
                    case "4":
                        SearchCard();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program!!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }

        }
    }
}