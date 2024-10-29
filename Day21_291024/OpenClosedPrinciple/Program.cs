// Objects or entities should be open for extension but closed for modification.

class DiscountCalculator
{
    public int CalculateDiscount(Discount discount)
    {
        return discount.GetDiscount();
    }
}

var calculator = new DiscountCalculator();
var res = calculator.CalculateDiscount(new.GoldDiscount());

public abstract class Discount
{
    public abstract int GetDiscount();
}

public class SilverDiscount : Discount
{
    Console.WriteLine("Silver Discount");
}
