using iTechArt.TestApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_application_iTechArt.Services.Interfaces
{
	public interface ICalculateService
	{
		IEnumerable<Depot> GetDepots();
		IEnumerable<DrugType> GetDrugTypes();
		IEnumerable<DrugUnit> SearchDrugUnits(int depotId, List<int> numbers);
	}
}
