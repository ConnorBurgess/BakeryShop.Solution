using Microsoft.AspNetCore.Mvc;
using BakeryShop.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BakeryShop.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly BakeryShopContext _db;
    public FlavorsController(BakeryShopContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.TreatTotal = _db.Treats.Count();
      return View(_db.Flavors.ToList());
    }
    public ActionResult Details(int id)
    {
      var thisFlavor = _db.Flavors
          .Include(flavor => flavor.JoinEntities)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }


    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor, int TreatId)
    {
        _db.Flavors.Add(flavor);
        _db.SaveChanges();
        if (TreatId != 0)
        {
            _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  
    public ActionResult Edit(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
        return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor, int TreatId)
    {
      if (TreatId != 0)
      {
        _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
      }
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddTreat(int id)
    {
        var thisTreat = _db.Flavors.FirstOrDefault(Flavor => flavor.FlavorId == id);
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
        return View(thisTreat);
    }

    [HttpPost]
    public ActionResult AddTreat(Flavor flavor, int TreatId)
    {
        if (TreatId != 0)
        {
        _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavor=> flavor.FlavorId == id);
        return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
        _db.Flavors.Remove(thisFlavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTreat(int joinId)
    {
        var joinEntry = _db.FlavorTreat.FirstOrDefault(entry => entry.FlavorTreatId == joinId);
        _db.FlavorTreat.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}