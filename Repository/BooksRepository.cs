using System.Collections.Generic;
using System.Linq;
using webdev.Interfaces;
using webdev.Models;

namespace webdev.Repository
{
    public class BooksRepository : IBooksRepository
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

        public void Delete(Book book) 
        {
            var bookToDelete = _books
                .SingleOrDefault(element => element.Author == book.Author && element.Title == book.Title);
            _books.Remove(bookToDelete);
        }
    }
}