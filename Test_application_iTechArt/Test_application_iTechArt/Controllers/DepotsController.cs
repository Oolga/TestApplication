using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_application_iTechArt.Controllers
{
    public class DepotsController : Controller
    {
		// GET: Depots
		public ActionResult Depots()
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
				return View("Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

	}
}