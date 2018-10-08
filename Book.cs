using System;

namespace lighteningExercises
{
    public class Book
    {
        public Book()
        {
            IsAvailable =true;
        }

        public string ISBN {get; set;}

           public string Author {get; set;}

           public string Title {get; set;}

           public bool IsAvailable { get; set;}
    }
}



// Make a Book class that has
// - Title property
// - Author property
// - ISBN (this will be a string) property
