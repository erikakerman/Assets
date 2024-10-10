using System;
using System.Collections.Generic;

// File: Program.cs
class Program
{
    static void Main()
    {
        // Initialize a list to store assets
        List<Asset> assets = new List<Asset>();

        while (true)
        {
            // Ask for user input
            Console.Write("Enter asset name (or 'exit' to quit): ");
            string name = Console.ReadLine();

            // Check if the user wants to exit
            if (name.ToLower() == "exit")
                break;

            // If not exiting, ask for the value
            Console.Write("Enter asset value: ");
            string value = Console.ReadLine();

            // Create a new Asset object and add it to the list
            Asset asset = new Asset(name, value);
            assets.Add(asset);

            Console.WriteLine($"Added {name} with value {value} to the assets.");
            Console.WriteLine(); // Print a blank line for readability
        }

        // Print the final list of assets
        Console.WriteLine("\nYour assets:");
        foreach (var asset in assets)
        {
            Console.WriteLine($"Name: {asset.Name}, Value: {asset.Value}");
        }
    }
}