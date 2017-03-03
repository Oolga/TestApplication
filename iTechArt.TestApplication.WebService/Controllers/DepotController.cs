using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;


namespace iTechArt.TestApplication.WebService.Controllers
{
	public class DepotController : ApiController
    {
		IDepotsService depotService;

	
		// GET: api/Depot
		public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

		public JsonResult GetDepotsContent(int first, int count) {
			DepotsViewModel model = new DepotsViewModel();

			depotService = new DepotsService(new DepotRepository(), new DrugUnitRepository());

			model.CountDrugUnits = depotService.CetCountOfDrugUnits();
			model.Depots = depotService.GetDepots();
			model.DrugUnits = depotService.GetSomeDrugUnits(first, count);
			model.RenderDrugUnits = model.DrugUnits.Count() > 0;
			model.RenderDepots = model.Depots.Count() > 0;

			return new JsonResult()
			{
				Data = model,
				JsonRequestBehavior = JsonRequestBehavior.AllowGet,
				MaxJsonLength = Int32.MaxValue
			};
		}
		// GET: api/Depot/5
		public string Get(int id)
        {
            return "value";
        }

        // POST: api/Depot
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Depot/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Depot/5
        public void Delete(int id)
        {
        }
    }
}
