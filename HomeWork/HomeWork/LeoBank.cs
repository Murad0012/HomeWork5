namespace Abstraction__Method_Override__Abstract___Sealed_classes
{
    public class LeoBankCard : BankCard
    {
        public LeoBankCard(int code, int cvv, double amount, string name, string surname) : base(code, cvv, amount, name, surname) { }
        public override void medaxil(double outPutValue) { Console.WriteLine(Amount - outPutValue); }
        public override void mexaric(double outPutValue) { Console.WriteLine(Amount + outPutValue); }
    }
}
