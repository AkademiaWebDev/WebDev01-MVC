using System.Collections.Generic;
using webdev.Models;

namespace webdev.Interfaces
{
    public interface IRepository
    {
         List<Book> GetBooks();
         void AddBook(Book book);
         void Delete(Book book);
    }
}