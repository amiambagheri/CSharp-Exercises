using System;

namespace Inventory_Management;

public class ElectronicDetails(string brand, double price)
{
    private string brand = brand;
    private double price = price;

    public override string ToString()
    {
        return $"Brand: {brand} , Price: ${price}";
    }
}
