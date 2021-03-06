﻿using iTechArt.TestApplication.DAL.EF;
using System.Collections.Generic;

namespace iTechArt.TestApplication.DAL.Interfaces
{
	public interface IDrugTypeRepository
    {
        IEnumerable<DrugType> GetAll();
    }
}
