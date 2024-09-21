using System;

namespace Library_Catalog;

public class FictionBook(string Title, string Author, int Pages, string Genre) : Book(Title, Author, Pages)
{

    public string Genre = Genre;

    public override void DisplayAditionalInfo()
    {
        Console.WriteLine($"Genre: {Genre}");
    }

}
