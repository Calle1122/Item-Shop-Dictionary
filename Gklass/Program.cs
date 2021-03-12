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

            List<string> boughtItems = new List<string>();

            shopItems.Add("Bronze Sword", 15);
            shopItems.Add("Chainmail Chestplate", 30);
            shopItems.Add("Shining Catalyst", 50);

            while(money >= 15){
                Console.WriteLine("Money: " + money + "\n");

                foreach (string key in shopItems.Keys)
                {
                    Console.WriteLine(key + ": " + shopItems[key]);
                }

                Console.WriteLine("\nPlease enter the name of the item you would like to purchase.");
                string playerInput = Console.ReadLine();

                if(shopItems.ContainsKey(playerInput)){
                    if(money < shopItems[playerInput]){
                        System.Console.WriteLine("\nYou can't afford this item.");
                        System.Console.WriteLine("Press ENTER and try again.");
                    }

                    else{
                        System.Console.WriteLine("\nYou bought the " + playerInput + " for " + shopItems[playerInput] + "$");

                        money = money - shopItems[playerInput];

                        boughtItems.Add(playerInput);
                    }
                }

                else{
                    System.Console.WriteLine("\nPlease enter a valid item name!");
                    System.Console.WriteLine("Press ENTER and try again.");
                }

                Console.ReadLine();
                Console.Clear();
            }

            System.Console.WriteLine("You can't afford another item.");
            System.Console.WriteLine("This is what you bought:\n");

            foreach (string item in boughtItems)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("\nMoney left over: " + money + "$");
 
            Console.ReadLine();
        }
    }
}
