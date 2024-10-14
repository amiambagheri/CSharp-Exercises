using System;

namespace Inventory_Management;

public class ClothingDetails(string size, string material)
{
    private string size = size;
    private string material = material;

    public override string ToString()
    {
        return $"Size: {size} , Material: {material}";
    }
}
