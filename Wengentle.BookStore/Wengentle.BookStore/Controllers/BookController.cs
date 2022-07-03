using Microsoft.AspNetCore.Mvc;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data  = _bookRepository.GetAllBooks();

            return View();
        }
        public ViewResult getBook(int id)
        {
            var data = _bookRepository.GetBookById(id);
            return View();
        }
        public ViewResult searchBooks(string bookName, string authorName)
        {
            var data  = _bookRepository.SearchBook(bookName, authorName);
            return View();
        }
    }
}
