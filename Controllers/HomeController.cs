using System;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Book_Store.Models;

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

        [Route("aboutUs")]
        public ViewResult AboutUs()
        {
            return View();
        }

        [Route("contactUs")]
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
