using System;

namespace ECommerce  
{
    public class BillingService
    {
        private readonly IDiscountStrategy discountStrategy;

        public BillingService(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(Cart cart) 
        {
            decimal totalAmount = cart.GetTotalWithoutDiscount();
            return discountStrategy.ApplyDiscount(cart);
        }
    }
}