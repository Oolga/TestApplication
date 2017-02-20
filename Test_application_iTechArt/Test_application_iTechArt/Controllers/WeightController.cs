using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArtTestApplication.DAL.Interfaces;
using iTechArtTestApplication.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_application_iTechArt.Controllers
{
    public class WeightController : Controller
    {
		// GET: Weight
		public ActionResult Weight()
		{
			try
			{
				IDrugTypeRepository drugTypeRepository = new DrugTypeRepository();
				IDepotRepository depotRepository = new DepotRepository();

				ViewBag.drugTypes = drugTypeRepository.GetAll();
				ViewBag.depots = depotRepository.GetAll();
				return View();
			}
			catch (Exception ex)
			{
				return View("Home/Error", new HandleErrorInfo(ex, "Weight", "Weight"));
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
				return View("Home/Error", new HandleErrorInfo(ex, "Weight", "ShowWeight"));
			}
		}

	}
}