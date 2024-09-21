using System;
using System.ComponentModel.DataAnnotations;

namespace Library_Catalog;

abstract public class Book(string Title, string Author, int Pages)
{
    public string Title = Title;
    public string Author = Author;
    public int Pages = Pages;


    public abstract void DisplayAditionalInfo();


    public void DisplayGeneralInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Pages: {Pages}");
    }
}
