using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        // routes go here

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}