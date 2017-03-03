using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iTechArt.TestApplication.WebService.Controllers
{
    public class DrugUnitToDepotController : ApiController
    {
		// GET: api/DrugUnitToDepot
		IDrugUnitToDepotService unitToDepotService=new DrugUnitToDepotService(new DepotRepository(),new DrugUnitRepository());

		[HttpPost]
		public void PostDrugUnitToDepot(JObject param)
		{
			unitToDepotService.UpdateUnitByDepotId(1,2);//drugUnitId, depotId);
		}
		public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DrugUnitToDepot/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DrugUnitToDepot
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DrugUnitToDepot/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DrugUnitToDepot/5
        public void Delete(int id)
        {
        }
    }
}
