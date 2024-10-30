using System.Collections.Generic;
using System.Linq;

namespace ECommerce
{
    public class BillingService
    {
        private readonly IDiscountStrategy _discountStrategy;

        public BillingService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotalAmount(List<CartItem> cartItems)
        {
            var totalAmount = cartItems.Sum(i => i.TotalPrice);
            System.Console.WriteLine($"Amount before discount: {totalAmount}");
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }
}