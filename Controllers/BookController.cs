using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Store.Models;
using Book_Store.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    public class BookController : Controller
    {
        //Each method in a controller is known as an "Action Method"
        private readonly BookRepository bookRepository = null;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        { 
            var stock = bookRepository.GetAllBooks();
            return View(stock);
        }

        public ViewResult GetBookById(int id)  
        {
            var bookDetails = bookRepository.GetBookById(id);
            return View(bookDetails);
        }
        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return bookRepository.SearchBook(bookName, authorName);
        }
    }
}
