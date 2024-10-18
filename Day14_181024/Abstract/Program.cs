namespace Abstract
{
    abstract class CalculatorBase
    {
        public void Add(int a, int b) => System.Console.WriteLine(a + b);
        public void Subtract(int a, int b) => System.Console.WriteLine(a - b);
        public void Multiply(int a, int b) => System.Console.WriteLine(a * b);
        public virtual void Divide(int a, int b) => System.Console.WriteLine(a / b);
        public abstract void Power(int a, int b);
    }

    class Calculator : CalculatorBase
    {
        public override void Divide(int a, int b)
        {
            if (b == 0)
            {
                System.Console.WriteLine("Division by zero not possible.");
                return;
            }
            base.Divide(a, b);
        }

        public override void Power(int a, int b)
        {
            System.Console.WriteLine(Math.Pow((double)a, (double)b));  // Cast to double for Math.Pow
        }
    }
}
