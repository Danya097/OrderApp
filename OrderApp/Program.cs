using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            {"Burger", 5.99},
            {"Pizza", 7.99},
            {"Salad", 4.99},
            {"Soda", 1.99},
            {"Water", 0.99}
        };

        List<string> order = new List<string>();
        double total = 0.0;

        Console.WriteLine("🍽️ Welcome to Lunch Order App!");
        Console.WriteLine("📋 Here is our menu:");

        foreach (var item in menu)
        {
            Console.WriteLine($"  {item.Key} - ${item.Value}");
        }

        
        while (true)
        {
            Console.Write("\n👉 Enter item to add to your order (or type 'done' to finish): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
                break;

            if (menu.ContainsKey(input))
            {
                order.Add(input);
                total += menu[input];
                Console.WriteLine($"✅ {input} added to your order.");
            }
            else
            {
                Console.WriteLine("❌ Item not found. Please try again.");
            }
        }

      
        Console.Write("\n📦 Please enter your delivery address: ");
        string address = Console.ReadLine();

       
        Console.WriteLine("\n🧾 Your Order:");
        foreach (string item in order)
        {
            Console.WriteLine($" - {item} (${menu[item]})");
        }

        Console.WriteLine($"\n💰 Total: ${total:F2}");
        Console.WriteLine($"🚚 Your order will be delivered to: {address}");
        Console.WriteLine("\n🎉 Thank you for using Lunch Order App!");
    }
}
