using System;

// File: Asset.cs
public class Asset
{
    public string Name { get; set; }
    public string Value { get; set; }

    // Constructor to create an asset
    public Asset(string name, string value)
    {
        Name = name;
        Value = value;
    }
}