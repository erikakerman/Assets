using System;

// Base class for all assets
public class Asset
{
    // Properties to store asset information
    public string Brand { get; set; }
    public string ModelName { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set; }
    public DateTime EndOfLife { get; set; }

    // Constructor to initialize an asset
    public Asset(string brand, string modelName, DateTime purchaseDate, int price)
    {
        Brand = brand;
        ModelName = modelName;
        PurchaseDate = purchaseDate;
        Price = price;
        EndOfLife = purchaseDate.AddYears(3); // Set end of life to 3 years from purchase date
    }
}