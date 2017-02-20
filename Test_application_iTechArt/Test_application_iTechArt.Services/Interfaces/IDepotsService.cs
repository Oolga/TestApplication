using iTechArt.TestApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_application_iTechArt.Services.Interfaces
{
	public interface IDepotsService
	{
		IEnumerable<Depot> GetDepots();
		IEnumerable<DrugUnit> GetDrugUnits();
	}
}
