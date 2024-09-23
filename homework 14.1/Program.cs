using System.Runtime.CompilerServices;

namespace Bank_account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Account card = new Account("PrivatBank", 200);
            Account card2 = new Account("MonoBank", 370.60);

            card.deposite(140.35);
            Console.WriteLine($"The balans of {card.nameCard} now: {card.amountOfMoney:c}");
            card2.windrawMoney(60);
            Console.WriteLine($"The balans of {card2.nameCard} now: {card2.amountOfMoney:c}");
            card.viewBalance();
        }
    }
}
