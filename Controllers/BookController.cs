using System;
using System.Collections.Generic;
using System.Dynamic;
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

        [Route("stock", Name = "GetBooks")]
        public ViewResult GetAllBooks()
        { 
            var stock = bookRepository.GetAllBooks();
            return View(stock);
        }

        [Route("explore/{id}",Name = "GetBookByIdRoute")]
        public ViewResult GetBookById(int id)  
        {
            //Simple object
            var bookDetails = bookRepository.GetBookById(id);

            //Anonymous object
            dynamic data = new ExpandoObject();

            data.book = bookDetails;
            data.Test = "Test sample data";

            return View(bookDetails);
        }
        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return bookRepository.SearchBook(bookName, authorName);
        }
    }
}
