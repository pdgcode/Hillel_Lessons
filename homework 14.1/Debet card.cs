using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    public class Account
    {
        public string nameCard;
        public double amountOfMoney;
        public Account(string nameCard, double amountOfMoney)
        {
            this.nameCard = nameCard;
            this.amountOfMoney = amountOfMoney;
        }

        public double deposite(double cash)
        {
            return amountOfMoney += cash;
        }

        public double windrawMoney(double cash)
        {
            if (amountOfMoney - cash < 0)
            {
                Console.WriteLine("Not enought of money!");
                return amountOfMoney;

            }
            else
            {
                return amountOfMoney -= cash;
            }
        }

        public void viewBalance()
        {
            Console.WriteLine($"{nameCard} balance {amountOfMoney:c}");
        }
    }
}

