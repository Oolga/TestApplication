using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DAL.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using iTechArt.TestApplication.DTO.Models;

namespace iTechArt.TestApplication.DAL
{
	public class DepotRepository : BaseRepository<Depot>, IDepotRepository
	{
		public IEnumerable<DrugUnitDTO> GetSomeDrugUnits(int first, int count)
		{
			var firstParam = new SqlParameter("@first", 10);
			//firstParam.SqlDbType = SqlDbType.Int;
			//firstParam.Direction = ParameterDirection.Input;

			var v = _context.Database.SqlQuery<DrugUnitDTO>("select * from dbo.GetDrugUnits("+first+","+count+")");

			return v; 
		}
	}
}
