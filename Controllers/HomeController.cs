using System;
using Microsoft.AspNetCore.Mvc;
namespace Book_Store.Controllers
{
    public class HomeController : Controller //Inherits Controller
    {
        public HomeController()
        {
        }
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
