namespace CreditCard
{
    class CreditCard
    {
        public string CardHolderName;
        public string CardNumber;
        public string Expiry;
        public int SecurityCode;

        public override string ToString()
        {
            return $"CardHolderName: {CardHolderName}, CardNumber: {CardNumber}, Expiry: {Expiry}, SecurityCode: {SecurityCode}";
        }
    }
}