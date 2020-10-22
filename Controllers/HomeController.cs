using System;
using Microsoft.AspNetCore.Mvc;
namespace Book_Store.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public string Index()
        {
            return "Book Store";
        }
    }
}
