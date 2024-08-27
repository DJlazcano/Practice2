using Practice2.StudentsC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.LibraryA
{

    public class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddBook(string title, int bookId)
        {
            books.Add(new Book(title, bookId));
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($"\nBook {book.Title} removed.\n");
        }

        //Remove by Book ID
        public void RemoveBook(int bookId)
        {
            Book rmBook = books.Find(s => s.BookId == bookId);
            books.Remove(rmBook);
            Console.WriteLine($"\nBook {rmBook.Title} removed.\n");
        }

        public void ListBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
