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
    
    public partial class mState
    {
        public mState()
        {
            this.mCity = new HashSet<mCity>();
        }
    
        public decimal mStateId { get; set; }
        public Nullable<decimal> mCountryId { get; set; }
        public string StateName { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ICollection<mCity> mCity { get; set; }
        public virtual mCountry mCountry { get; set; }
    }
}
