namespace ECommerce
{
    public class FlatDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - 200;
    }
}