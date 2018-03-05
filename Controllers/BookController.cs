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
            var book = new Book
            {
                Title = "Lód",
                Author = "Jacek Dukaj"
            };
            return View(book);
        }
    }
}