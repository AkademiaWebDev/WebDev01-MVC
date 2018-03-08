using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webdev.Interfaces;
using webdev.Models;

namespace webdev.Controllers
{
    public class BookController : Controller
    {
        private IBooksRepository _repository;
        
        public BookController(IBooksRepository booksRepository)
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

        [HttpGet]
        public IActionResult Delete(Book book)
        {
            _repository.Delete(book);
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult Edit(Book book) 
        {
            return View(book);
        }
        
        [HttpPost]
        public IActionResult Update(Book book) 
        {
            _repository.Update(book);
            return Redirect("Index");
        }
    }
}