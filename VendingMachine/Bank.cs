using System;

namespace VendingMachine
{
    public class Bank
    {
        public static void CardStatement(User user)
        {
            Console.WriteLine($"You have {user.CreditCard}$ on your creditcard");
        }

        public static void Withdraw(int amount, User user)
        {
            if (amount > 0)
            {
                user.CreditCard += amount;
                Console.WriteLine($"We added {amount}$ to your creditcard");
            }
            else
            {
                Console.WriteLine("The amount needs to be bigger than 0");
            }
        }
    }
}