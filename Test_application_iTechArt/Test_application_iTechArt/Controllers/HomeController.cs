using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Test_application_iTechArt.DAL;
using Test_application_iTechArt.DAL.Interfaces;
using Test_application_iTechArt.DAL.Models;
using Test_application_iTechArt.Services.Domain;
using Test_application_iTechArt.Services.Interfaces;

namespace Test_application_iTechArt.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult UnitsSearch(int depotId, List<int> numbers)
        {

            List<DrugUnit> units = new List<DrugUnit>();
            try
            {
                IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

                for (int i = 0; i < numbers.Count(); i++)
                {
                    for (int j = 0; j < numbers.ElementAt(i); j++)
                    {
                        if (j < (drugUnitRepository.GetAll().Where(x => x.DepotId == depotId && x.DrugTypeId == (i + 1))).ToList<DrugUnit>().Count)
                            units.Add((drugUnitRepository.GetAll().Where(x => x.DepotId == depotId && x.DrugTypeId == (i + 1))).ToList<DrugUnit>().OrderBy(x=>x.PickNumber).ElementAt(j));
                    }
                }


                return PartialView(units);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "UnitsSearch"));
            }
        }

        public ActionResult ShowWeight(int depotId, int drugTypeId)
        {
            try
            {
				IDrugUnitService service = new DrugUnitService();
				var units = service.GetDrugUnitsForDepot(depotId, drugTypeId);

                return PartialView(units);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "ShowWeight"));
            }
        }
    

        public ActionResult Сalculate()
        {
            try
            {
                IDepotRepository depotRepository = new DepotRepository();
                IDrugTypeRepository drugTypeRepository = new DrugTypeRepository();

                ViewBag.depots = depotRepository.GetAll();
                ViewBag.drugTypes = drugTypeRepository.GetAll();

                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "Сalculate"));
            }

        }

        public ActionResult Depots()
        {
            try
            {
                IDepotRepository depotRepository = new DepotRepository();
                IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

                ViewBag.depots = depotRepository.GetAll();
                ViewBag.drugUnits =drugUnitRepository.GetAll();

                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "Depots"));
            }
        }

        public ActionResult DrugUnitToDepot()
        {
            try
            {
                IDepotRepository depotRepository = new DepotRepository();
                IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

                ViewBag.depots = depotRepository.GetAll();
                ViewBag.drugUnits = drugUnitRepository.GetAll();
                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "DrugUnitToDepot"));
            }
        }

        public ActionResult UpdateDrugUnitToDepot(int DrugUnitId, int DepotId)
        {
            try
            {
                IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

                DrugUnit unit = drugUnitRepository.GetAll().Where(x => x.DrugUnitId == DrugUnitId).First();
                unit.DepotId = DepotId;
                drugUnitRepository.Update(unit);

                return Redirect("MessageWindow?message=Changes saved.");
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "UpdateDrugUnitToDepot"));
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
                IDrugTypeRepository drugTypeRepository = new DrugTypeRepository();
                IDepotRepository depotRepository = new DepotRepository();

                ViewBag.drugTypes =drugTypeRepository.GetAll();
                ViewBag.depots = depotRepository.GetAll();
                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "Weight"));
            }
        }


    }
}