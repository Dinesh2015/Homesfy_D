//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homesfy.Entities.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocalitySuggestions
    {
        public decimal LocalitySuggestionId { get; set; }
        public string mChildLocalityId { get; set; }
        public Nullable<decimal> mLocalityId { get; set; }
    
        public virtual mLocality mLocality { get; set; }
    }
}
