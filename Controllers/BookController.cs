using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webdev.Interfaces;
using webdev.Models;
using webdev.Repository;

namespace webdev.Controllers
{
    public class BookController : Controller
    {
        private IRepository _repository;
        
        public BookController(IRepository booksRepository)
        {
            _repository = booksRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _repository.GetBooks();
            return View(books);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _repository.AddBook(book);
            return Redirect("Index");
        }
    }
}