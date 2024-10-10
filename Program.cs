using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store all assets
        List<Asset> assets = new List<Asset>();

        // Main loop for user input
        while (true)
        {
            Console.WriteLine("Enter asset type (Computer/Phone) or 'exit' to quit:");
            string assetType = Console.ReadLine();

            // Check if user wants to exit
            if (assetType.ToLower() == "exit")
                break;

            // Get asset details from user
            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Model Name: ");
            string modelName = Console.ReadLine();

            Console.Write("Purchase Date (yyyy-MM-dd): ");
            DateTime purchaseDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());

            // Create and add the appropriate asset type
            if (assetType.ToLower() == "computer")
                assets.Add(new Computer(brand, modelName, purchaseDate, price));
            else if (assetType.ToLower() == "phone")
                assets.Add(new Phone(brand, modelName, purchaseDate, price));

            Console.WriteLine("Asset added.\n");
        }

        // Display all assets
        Console.WriteLine("\nAsset List:");
        foreach (var asset in assets)
        {
            Console.WriteLine($"{asset.Brand} {asset.ModelName}, " +
                              $"Purchased: {asset.PurchaseDate.ToShortDateString()}, " +
                              $"Price: {asset.Price}, " +
                              $"End of Life: {asset.EndOfLife.ToShortDateString()}");
        }
    }
}