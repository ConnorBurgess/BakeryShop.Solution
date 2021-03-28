using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BakeryShop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BakeryShop.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryShopContext _db;
    public HomeController(BakeryShopContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      
      ViewBag.TreatList = _db.Treats.ToList();
      var currentFlavor = _db.Flavors
        .Include(flavor => flavor.JoinEntities)
        .ThenInclude(join => join.Treat);
      return View(currentFlavor.ToList());
    }

  }
}