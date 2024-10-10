// Class representing a computer asset
public class Computer : Asset
{
    // Constructor for creating a new computer asset
    public Computer(string brand, string modelName, DateTime purchaseDate, int price)
        : base(brand, modelName, purchaseDate, price)
    {
    }
}

// Class representing a phone asset
public class Phone : Asset
{
    // Constructor for creating a new phone asset
    public Phone(string brand, string modelName, DateTime purchaseDate, int price)
        : base(brand, modelName, purchaseDate, price)
    {
    }
}