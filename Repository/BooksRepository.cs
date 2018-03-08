using System.Collections.Generic;
using System.Linq;
using webdev.Interfaces;
using webdev.Models;

namespace webdev.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private List<Book> _books;

        public BooksRepository()
        {
            _books = new List<Book>
            {
                new Book { Id = 0, Title = "Lód", Author = "Jacek Dukaj" },
                new Book { Id = 1, Title = "Valis", Author = "Philip K. Dick" }
            };
        }

        public void AddBook(Book book) 
        {
            book.Id = _books.Count;
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

        public void Update(Book book) 
        {
            var bookToUpdateIndex = _books.FindIndex(element => element.Id == book.Id);
            if(bookToUpdateIndex != -1) 
                _books[bookToUpdateIndex] = book;
        }
    }
}