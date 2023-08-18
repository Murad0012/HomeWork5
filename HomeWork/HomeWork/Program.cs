namespace Abstraction__Method_Override__Abstract___Sealed_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new UnibankCard(123456789, 123, 100, "Murad", "Memmedzade");
            test1.medaxil(20);
            test1.mexaric(20);

            var test2 = new AccessBankCard(123456789, 123, 100, "Murad", "Memmedzade");
            test2.medaxil(20);
            test2.mexaric(20);

            var test3 = new PashaBankCard(123456789, 123, 100, "Murad", "Memmedzade");
            test3.medaxil(20);
            test3.mexaric(20);

            var test4 = new LeoBankCard(123456789, 123, 100, "Murad", "Memmedzade");
            test4.medaxil(20);
            test4.mexaric(20);
        }
    }
}


