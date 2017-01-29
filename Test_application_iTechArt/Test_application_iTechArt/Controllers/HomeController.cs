using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_application_iTechArt.Models;

namespace Test_application_iTechArt.Controllers
{
    public class HomeController : Controller
    {
        Entities1 db = new Entities1();

        public ActionResult UnitsSearch(int depotId, List<int> numbers)
        {

            List<DrugUnit> units = new List<DrugUnit>();
            try
            {
                for (int i = 0; i < numbers.Count(); i++)
                {
                    for (int j = 0; j < numbers.ElementAt(i); j++)
                    {
                        if (j < (db.DrugUnit.Where(x => x.DepotId == depotId && x.DrugTypeId == (i + 1))).ToList<DrugUnit>().Count)
                            units.Add((db.DrugUnit.Where(x => x.DepotId == depotId && x.DrugTypeId == (i + 1))).ToList<DrugUnit>().OrderBy(x=>x.PickNumber).ElementAt(j));
                    }
                }


                return PartialView(units);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Hello", "UnitsSearch"));
            }
        }

        public ActionResult ShowWeight(int depotId, int drugTypeId)
        {
            try
            {
                List<DrugUnit> units = db.DrugUnit.Where(x => x.DepotId == depotId && x.DrugTypeId == drugTypeId).ToList<DrugUnit>();
                units.ForEach(x => x.DrugType.Weight = Math.Round(x.DrugType.Weight / 2.2, 2));

                return PartialView(units);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Hello", "ShowWeight"));
            }
        }
    

        public ActionResult Сalculate()
        {
            try
            {
                ViewBag.depots = db.Depot.ToList<Depot>();
                ViewBag.drugTypes = db.DrugType.ToList<DrugType>();

                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Hello", "Сalculate"));
            }

        }

        public ActionResult Depots()
        {
            try
            {
                ViewBag.depots = db.Depot.ToList<Depot>();
                ViewBag.drugUnits = db.DrugUnit.ToList<DrugUnit>();

                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Hello", "Depots"));
            }
        }

        public ActionResult DrugUnitToDepot()
        {
            try
            {
                ViewBag.depots = db.Depot.ToList<Depot>();
                ViewBag.drugUnits = db.DrugUnit.ToList<DrugUnit>();
                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Hello", "DrugUnitToDepot"));
            }
        }

        public ActionResult UpdateDrugUnitToDepot(int DrugUnitId, int DepotId)
        {
            try
            {
                DrugUnit unit = db.DrugUnit.Where(x => x.DrugUnitId == DrugUnitId).First();
                unit.DepotId = DepotId;
                db.SaveChanges();

                return Redirect("MessageWindow?message=Changes saved.");
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Hello", "UpdateDrugUnitToDepot"));
            }
        }

        public ActionResult MessageWindow(string message)
        {
            ViewBag.message = message ;
            return PartialView();
        }

        public ActionResult Weight()
        {
            try
            {
                ViewBag.drugTypes = db.DrugType.ToList<DrugType>();
                ViewBag.depots = db.Depot.ToList<Depot>();
                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Hello", "Weight"));
            }
        }


    }
}