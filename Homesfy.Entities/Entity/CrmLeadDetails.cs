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
    
    public partial class CrmLeadDetails
    {
        public CrmLeadDetails()
        {
            this.CrmLeadFeedback = new HashSet<CrmLeadFeedback>();
        }
    
        public decimal crmLeadDetailsId { get; set; }
        public Nullable<decimal> UserId { get; set; }
        public Nullable<decimal> PropscoutId { get; set; }
        public Nullable<decimal> crmLeadPurposeId { get; set; }
        public Nullable<decimal> crmLeadSourceId { get; set; }
        public Nullable<decimal> mPropCategoryd { get; set; }
        public Nullable<decimal> mPropConfigId { get; set; }
        public Nullable<decimal> mClientInterestAreaId { get; set; }
        public Nullable<decimal> mClientInterestInBuilderId { get; set; }
        public Nullable<decimal> mClientExpectedPopArea { get; set; }
        public Nullable<decimal> LeadAssignDateTime { get; set; }
        public Nullable<System.DateTime> LeadFolloDateTime { get; set; }
        public Nullable<System.DateTime> LeadSiteVisitDateTime { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
        public string ClientNationality { get; set; }
    
        public virtual mCrmLeadPurpose mCrmLeadPurpose { get; set; }
        public virtual mCrmLeadSources mCrmLeadSources { get; set; }
        public virtual mPropConfig mPropConfig { get; set; }
        public virtual ICollection<CrmLeadFeedback> CrmLeadFeedback { get; set; }
    }
}
