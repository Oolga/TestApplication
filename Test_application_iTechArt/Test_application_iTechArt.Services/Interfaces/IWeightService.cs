using iTechArt.TestApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_application_iTechArt.Services.Interfaces
{
	public interface IWeightService
	{
		IEnumerable<Depot> GetDepots();
		IEnumerable<DrugType> GetDrugTypes();
		IEnumerable<DrugUnit> GetDrugUnitsForDepot(int depotId, int drugTypeId);
	}
}
