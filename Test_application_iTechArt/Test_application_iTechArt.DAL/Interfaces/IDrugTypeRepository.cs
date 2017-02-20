using iTechArt.TestApplication.DAL.Models;
using System.Collections.Generic;

namespace iTechArtTestApplication.DAL.Interfaces
{
	public interface IDrugTypeRepository
    {
        IEnumerable<DrugType> GetAll();
    }
}
