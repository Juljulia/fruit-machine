using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCard = 0;
            
            Inventory inventory = new Inventory();
            Bank bank = new Bank();
            User user = new User(creditCard);

            Options.DisplayOptions();
            
            while (true)
            {
                var selected = Console.ReadLine();

                switch (selected)
                {
                    case "1":
                        Console.WriteLine("BuyItem");
                        Inventory.BuyItem(user);
                        break;
                    case "2":
                        Bank.CardStatement(user);
                        Options.DisplayOptions();
                        break;
                    case "3":
                        Console.WriteLine("How much would you like to withdraw?");
                        int.TryParse(Console.ReadLine(), out var amount);
                        Bank.Withdraw(amount, user);
                        Options.DisplayOptions();
                        break;
                    default:
                        Console.WriteLine("You have to select one option of 1, 2 or 3 to go further in your shopping.");
                        break;
                }
            }
        }
    }
}