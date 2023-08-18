namespace Abstraction__Method_Override__Abstract___Sealed_classes
{
    public class PashaBankCard : BankCard
    {
        public PashaBankCard(int code, int cvv, double amount, string name, string surname) : base(code, cvv, amount, name, surname) { }
        public override void medaxil(double outPutValue)
        {
            double lastValue = outPutValue * 1.1 / 100;
            Console.WriteLine(Amount - outPutValue - lastValue);
        }
        public override void mexaric(double outPutValue)
        {
            double lastValue = outPutValue * 0.6 / 100;
            Console.WriteLine(Amount + outPutValue - lastValue);
        }
    }
}
