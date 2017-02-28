using iTechArt.TestApplication.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DTO.Models
{
	public class DepotDTO
	{
		public int Id { get; set; }
		public string DepotName { get; set; }
		public string CountryName { get; set; }
	}
}
