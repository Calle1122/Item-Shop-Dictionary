using System;
using System.Collections.Generic;

namespace Gklass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> shopItems = new Dictionary<string, int>();

            shopItems.Add("Bronze Sword", 15);
            shopItems.Add("Chainmail Chestplate", 30);
            shopItems.Add("Shining Catalyst", 50);

            foreach (string key in shopItems.Keys)
            {
                Console.WriteLine(key + ": " + shopItems[key]);
            }

            Console.ReadLine();
        }
    }
}
