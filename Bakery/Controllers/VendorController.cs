using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View();
        }

    }
}