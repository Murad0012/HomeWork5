namespace Abstraction__Method_Override__Abstract___Sealed_classes
{
    public abstract class BankCard
    {
        public int Code { get; private set; }
        public int CVV { get; private set; }
        public double Amount { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public BankCard(int code, int cvv, double amount, string name, string surname)
        {
            Name = name;
            Surname = surname;
            Amount = amount;
            Code = code;
            CVV = cvv;
        }
        public abstract void medaxil(double outPutValue);
        public abstract void mexaric(double outPutValue);
    }
}
