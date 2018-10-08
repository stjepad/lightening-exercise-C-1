using System;
using System.Collections.Generic;

namespace lighteningExercises {
    public class Library {
        // constructor. has to have the same name as the class
        public Library (List<Book> initialInventory, string name, string address) {
            _bookList = initialInventory;
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        private List<Book> _bookList = new List<Book> ();

        public void AddToInventory (Book book) {
            _bookList.Add (book);
        }

        // method so that members can check out books
        public void Checkout (string isbn, CardHolder cardHolder) {
            Book foundBook = new Book ();

            foreach (Book book in _bookList) {
                if (book.ISBN == isbn && book.IsAvailable) {

                    cardHolder.CheckoutBook (book);
                    book.IsAvailable = false;

                }
            }
        }

        public bool IsAvailable (string isbn) {
            foreach (Book book in _bookList) {
                if (book.ISBN == isbn) {
                    return book.IsAvailable;
                }
            }
            return false;
        }
    }
}

// Make a Library class that has:
// - Private List of Books (remember casing and naming convention here)
// - Public Method to add a Book to the List of Books
// - Public Address property
// - Public Name property