using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/categories/{categoryId}/items/new")]
    public ActionResult New(int categoryId)
    {
       Vendor category = Vendor.Find(categoryId);
       return View(category);
    }

    

  }
}