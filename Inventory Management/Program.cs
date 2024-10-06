using Inventory_Management;

List<Product<object>> inventory =
[
    new Product<object>("Laptop", ProductsCategory.Electronics, new ElectronicDetails("Dell", 899.99)),
            new Product<object>("T-Shirt", ProductsCategory.Clothing, new ClothingDetails("Medium", "Cotton")),
            new Product<object>("Book", ProductsCategory.Books, "Introduction to C# Programming"),
            new Product<object>("Apple", ProductsCategory.Food, "Red Delicious")
];

foreach (var product in inventory)
{
    Console.WriteLine("---------");
    product.DisplayInfo();
    Console.WriteLine("---------");
}