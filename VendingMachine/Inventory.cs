using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class Inventory
    {
        public static List<GoodsItem> items = new List<GoodsItem>()
        {
            new GoodsItem("Apple", 8, 10),
            new GoodsItem("Pear", 6, 0),
            new GoodsItem("Orange", 5, 1),
            new GoodsItem("Banana", 10, 3),
        };

        public static void BuyItem(User user)
        {
            Console.WriteLine("Which item do you want to buy?");
            Console.WriteLine(" ");
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }

            var selectedItem = Console.ReadLine();
            
            foreach (var item in items)
            {
                if (selectedItem == item.Name)
                {
                    if (user.CreditCard < item.Price)
                    {
                        Console.WriteLine("You don't have enough money on your creditcard");
                        Options.DisplayOptions();
                        break;
                    }

                    if (item.ItemsLeft == 0)
                    {
                        Console.WriteLine("Woops, that item is sold out. Please choose another item.");
                        BuyItem(user);
                        break;
                    }

                    Console.WriteLine("Yey, now you have a tasty fruit to eat. Welcome back to buy something more!");
                    user.CreditCard -= item.Price;
                    Options.DisplayOptions();
                }
            }

        }
    }
}