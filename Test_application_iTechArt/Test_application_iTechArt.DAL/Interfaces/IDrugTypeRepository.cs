using iTechArt.TestApplication.DAL.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.DAL.Interfaces
{
	public interface IDrugTypeRepository
    {
        IEnumerable<DrugType> GetAll();
    }
}
