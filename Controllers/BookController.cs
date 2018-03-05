using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webdev.Models;

namespace webdev.Controllers
{
    public class BookController : Controller
    {
        public BookController() { }

        [HttpGet]
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book { Title = "Lód", Author = "Jacek Dukaj" },
                new Book { Title = "Valis", Author = "Philip K. Dick" }
            };
            return View(books);
        }
    }
}