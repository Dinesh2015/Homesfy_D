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
    
    public partial class Builder
    {
        public Builder()
        {
            this.mBuilderProjects = new HashSet<mBuilderProjects>();
        }
    
        public decimal BuilderId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string BuilderLogo { get; set; }
        public string BuilderSpocName { get; set; }
        public string BuilderSpocContactNo { get; set; }
        public Nullable<decimal> ProjectsCompleted { get; set; }
        public Nullable<decimal> ProjectsActive { get; set; }
        public string UpcomingProjects { get; set; }
        public Nullable<decimal> CurrentInventory { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ModiFiedby { get; set; }
        public Nullable<System.DateTime> ModiFiedDate { get; set; }
    
        public virtual ICollection<mBuilderProjects> mBuilderProjects { get; set; }
    }
}
