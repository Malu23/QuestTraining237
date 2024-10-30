using System;
using System.Data.SqlClient;
using System.Threading;

namespace ECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Add(new CartItem { Name = "Pen", Price = 100, Quantity = 2 });
            cart.Add(new CartItem { Name = "Diary", Price = 200, Quantity = 3 });
            cart.Add(new CartItem { Name = "Bag", Price = 300, Quantity = 1 });
            
            var discountStrategy = new PercentageDiscountStrategy();
            var billingService = new BillingService(discountStrategy);
            var totalAmount = billingService.CalculateTotalAmount(cart.GetAll());
            
            Console.WriteLine($"Total amount: {totalAmount}");
            
            cart.Update("Pen", 5);
            totalAmount = billingService.CalculateTotalAmount(cart.GetAll());
            Console.WriteLine($"Total amount after updating and applying discount: {totalAmount}");
        }
    }
}