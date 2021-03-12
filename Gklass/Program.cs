using System;
using System.Collections.Generic;

namespace Gklass
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 50;

            Dictionary<string, int> shopItems = new Dictionary<string, int>();

            shopItems.Add("Bronze Sword", 15);
            shopItems.Add("Chainmail Chestplate", 30);
            shopItems.Add("Shining Catalyst", 50);

            Console.WriteLine("Money: " + money + "\n");

            foreach (string key in shopItems.Keys)
            {
                Console.WriteLine(key + ": " + shopItems[key]);
            }

            Console.WriteLine("\nPlease enter the name of the item you would like to purchase.");
            string playerInput = Console.ReadLine();

            if(shopItems.ContainsKey(playerInput)){
                System.Console.WriteLine("\nYou bought the " + playerInput + " for " + shopItems[playerInput] + "$");

                money = money - shopItems[playerInput];
            }

            Console.ReadLine();
        }
    }
}
