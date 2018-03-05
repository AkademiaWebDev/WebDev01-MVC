using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webdev.Models;

namespace webdev.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> _books = new List<Book>
        {
            new Book { Title = "Lód", Author = "Jacek Dukaj" },
            new Book { Title = "Valis", Author = "Philip K. Dick" }
        };
        
        public BookController()
        {
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