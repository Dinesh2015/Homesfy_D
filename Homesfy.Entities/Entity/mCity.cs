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
    
    public partial class mCity
    {
        public mCity()
        {
            this.mLocality = new HashSet<mLocality>();
        }
    
        public decimal mCityId { get; set; }
        public Nullable<decimal> mStateId { get; set; }
        public string CityName { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual mState mState { get; set; }
        public virtual ICollection<mLocality> mLocality { get; set; }
    }
}