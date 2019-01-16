using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Books controller’s Index action");
        }
        
        public IActionResult New()
        {
            return Content("This is the Books controller’s New action");
        }

        [ActionName("Best-Sellers")]
        public IActionResult BestSellers()
        {
            return Content("This is the Books controller’s Best action");
        }
    }
}