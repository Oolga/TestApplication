using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.Models;
using iTechArtTestApplication.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Test_application_iTechArt.Controllers
{
	public class СalculateController : Controller
    {
		// GET: Сalculate
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
				return View("Home/Error", new HandleErrorInfo(ex, "Сalculate", "Сalculate"));
			}

		}
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
							units.Add((drugUnitRepository.GetAll().Where(x => x.DepotId == depotId && x.DrugTypeId == (i + 1))).ToList<DrugUnit>().OrderBy(x => x.PickNumber).ElementAt(j));
					}
				}


				return PartialView(units);
			}
			catch (Exception ex)
			{
				return View("Home/Error", new HandleErrorInfo(ex, "Сalculate", "UnitsSearch"));
			}
		}
	}
}