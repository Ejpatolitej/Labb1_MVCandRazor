using Labb1_MVCAndRazor.Models;
using Labb1_MVCAndRazor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Labb1_MVCAndRazor.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ViewResult Index()
        {
            IEnumerable<Book> books;

            books = _bookRepository.GetAllBooks;

            return View(new BookViewModel
            {
                Books = books
            });
        }
    }
}
