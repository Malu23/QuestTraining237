namespace ECommerce
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _discountPercentage = 20;
        
        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - (totalAmount * _discountPercentage / 100);
    }
}