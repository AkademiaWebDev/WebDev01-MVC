using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webdev.Models;

namespace webdev.Controllers
{
    public class BookController : Controller
    {
        private List<Book> _books;
        
        public BookController()
        {
            _books = new List<Book>
            {
                new Book { Title = "Lód", Author = "Jacek Dukaj" },
                new Book { Title = "Valis", Author = "Philip K. Dick" }
            };
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_books);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _books.Add(book);
            return Redirect("Index");
        }
    }
}