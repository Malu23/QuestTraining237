using System;

namespace ECommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.AddItem(new CartItem("Laptop", 1, 1000));  
            cart.AddItem(new CartItem("Mouse", 2, 50));     

            Console.WriteLine("Total before discount: " + cart.GetTotalWithoutDiscount());

            IDiscountStrategy discountStrategy = new BuyOneGetOneFree();  

            var billingService = new BillingService(discountStrategy);

            Console.WriteLine("Total after discount: " + billingService.CalculateTotal(cart));
        }
    }
}