using System.Collections.Generic;
using webdev.Interfaces;
using webdev.Models;

namespace webdev.Repository
{
    public class BooksRepository : IRepository
    {
        public static List<Book> _books = new List<Book>
        {
            new Book { Title = "Lód", Author = "Jacek Dukaj" },
            new Book { Title = "Valis", Author = "Philip K. Dick" }
        };

        public void AddBook(Book book) 
        {
            _books.Add(book);
        }

        public List<Book> GetBooks() 
        {
            return _books;
        }
    }
}