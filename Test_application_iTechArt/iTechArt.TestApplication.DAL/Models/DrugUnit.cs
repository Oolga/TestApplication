//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iTechArt.TestApplication.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrugUnit
    {
        public int DrugUnitId { get; set; }
        public Nullable<int> PickNumber { get; set; }
        public Nullable<int> DepotId { get; set; }
        public int DrugTypeId { get; set; }
    
        public virtual Depot Depot { get; set; }
        public virtual DrugType DrugType { get; set; }
    }
}