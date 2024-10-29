namespace ECommerce
{
    public interface IDiscountStrategy
    { 
        decimal ApplyDiscount(Cart cart);
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal ApplyDiscount(Cart cart)
        {
            decimal totalAmount = cart.GetTotalWithoutDiscount();
            return totalAmount - (totalAmount * (percentage / 100));
        }
    }

    public class FlatDiscount : IDiscountStrategy
    {
        private readonly decimal discountAmount;

        public FlatDiscount(decimal discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(Cart cart)
        {
            decimal totalAmount = cart.GetTotalWithoutDiscount();
            return totalAmount - discountAmount;
        }
    }

    public class BuyOneGetOneFree : IDiscountStrategy
    {
        public decimal ApplyDiscount(Cart cart)
        {
            decimal totalAmount = 0;

            foreach (var item in cart.GetItems())
            {
                int chargeableItems = (item.Quantity / 2) + (item.Quantity % 2);  

                totalAmount += chargeableItems * item.Price;
            }

            return totalAmount;
        }
    }
}

