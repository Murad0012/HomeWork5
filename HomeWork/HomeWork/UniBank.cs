namespace Abstraction__Method_Override__Abstract___Sealed_classes
{
    public class UnibankCard : BankCard
    {
        public UnibankCard(int code, int cvv, double amount, string name, string surname) : base(code, cvv, amount, name, surname) { }
        public override void medaxil(double outPutValue)
        {
            double lastValue = outPutValue * 1.5 / 100;
            Console.WriteLine(Amount - outPutValue - lastValue);
        }

        public override void mexaric(double outPutValue) { Console.WriteLine(Amount + outPutValue); }
    }
}
