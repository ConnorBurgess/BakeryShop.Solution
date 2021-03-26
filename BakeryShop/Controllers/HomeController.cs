using Microsoft.AspNetCore.Mvc;

namespace BakeryShop.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}