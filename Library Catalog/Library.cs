using System;

namespace Library_Catalog;

static public class Library
{
    static public void DisplayBooks(Book[] books)
    {


        foreach (Book book in books)
        {

            Console.WriteLine("-----------");
            book.DisplayGeneralInfo();
            book.DisplayAditionalInfo();
            Console.WriteLine("-----------");
        }

    }
}
