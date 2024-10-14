using System;

namespace Inventory_Management;

public class Product<T>(string name, ProductsCategory category, T details)
{
    private string name = name;
    private ProductsCategory category = category;
    private T details = details;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Category : {category}");
        Console.WriteLine($"Details : {details}");
    }

}
