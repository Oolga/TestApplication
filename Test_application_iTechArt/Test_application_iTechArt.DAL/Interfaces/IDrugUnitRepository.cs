﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_application_iTechArt.DAL.Models;

namespace Test_application_iTechArt.DAL.Interfaces
{
    public interface IDrugUnitRepository
    {
       IEnumerable<DrugUnit> GetAll();
       void Update(DrugUnit drugUnit);
    }
}
