using System;

namespace Library_Catalog;

sealed public class NonFictionBook(string Title, string Author, int Pages, string Topic) : Book(Title, Author, Pages)
{

    public string Topic = Topic;
    public override void DisplayAditionalInfo()
    {
        Console.WriteLine($"Genre: {Topic}");

    }

}
