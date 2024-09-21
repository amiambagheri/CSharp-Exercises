using System;

namespace Library_Catalog;

public class ArtBook(string Title, string Author, int Pages, string Style) : Book(Title, Author, Pages)

{
    public string Style = Style;
    public override void DisplayAditionalInfo()
    {
        Console.WriteLine($"Genre: {Style}");

    }
}