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
            Console.Write("Asset type (Computer/Phone): ");
            string assetType = Console.ReadLine();

            // Check if user wants to exit
            if (assetType.ToLower() == "exit")
                break;

            // Get asset details from user
            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Model: ");
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

        // Display all assets in a table format
        Console.WriteLine("{0,-10} {1,-10} {2,-15} {3,-10} {4,-15} {5,-15}",
            "Type", "Brand", "Model", "Price", "Purchase Date", "Expiration Date");
        Console.WriteLine(new string('-', 80)); // Print a line of dashes

        // Iterate through all assets and display their information
        foreach (var asset in assets)
        {
            string type = asset is Computer ? "Computer" : "Phone";
            Console.WriteLine("{0,-10} {1,-10} {2,-15} {3,-10} {4,-15:MM/dd/yyyy} {5,-15:MM/dd/yyyy}",
                type,
                asset.Brand,
                asset.ModelName,
                asset.Price,
                asset.PurchaseDate,
                asset.EndOfLife);
        }
    }
}