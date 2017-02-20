using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_application_iTechArt.Services.Domain;
using Test_application_iTechArt.Services.Interfaces;

namespace Test_application_iTechArt.Controllers
{
    public class DepotsController : Controller
    {
		// GET: Depots
		public ActionResult Depots()
		{
			try
			{
				IDepotsService service = new DepotsService();

				ViewBag.depots = service.GetDepots();
				ViewBag.drugUnits = service.GetDrugUnits();

				return View();
			}
			catch (Exception ex)
			{
				return View("Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

	}
}