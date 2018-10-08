using System;
using System.Collections.Generic;

namespace lighteningExercises
{
    public class Meow

    {






            static void Main (string[] args)
        {
            Book endersGame = new Book() {
                Title = "Ender's Game",
                Author = "Orson Scott",
                ISBN = "ABC123"
            };

            Book book2 = new Book() {
                Title = "title",
                Author = "author",
                ISBN = "ISBNNUMBER"
            };

            Book book3 = new Book() {
                Title = "lotr",
                Author = "Tolkien",
                ISBN = "zoomzoom"
            };

            Book book4 = new Book() {
                Title = "book4",
                Author = "author4",
                ISBN = "kachow"
            };

            List <Book> books = new List<Book>(){
book4
            };


            Library library = new Library(books, "Downtown Library", "123 fake street downtown");

            library.AddToInventory(endersGame);
            library.AddToInventory(book2);
            library.AddToInventory(book3);

        if (library.IsAvailable("kachow"))
        {
            Console.WriteLine("it is available");
        }
        else
        {
            {
                Console.WriteLine("not available");
            }
        }
        }
    }
}



// Make a Book class that has
// - Title property
// - Author property
// - ISBN (this will be a string) property
