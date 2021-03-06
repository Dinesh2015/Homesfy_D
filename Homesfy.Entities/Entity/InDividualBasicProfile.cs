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
    
    public partial class InDividualBasicProfile
    {
        public decimal Id { get; set; }
        public Nullable<decimal> UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SelfIntroDuction { get; set; }
        public Nullable<decimal> MobileNo { get; set; }
        public Nullable<decimal> SecurityQuestionId { get; set; }
        public string SecurityAnswer { get; set; }
        public string ProfileImage { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ModiFiedBy { get; set; }
        public Nullable<System.DateTime> ModiFiedDate { get; set; }
    
        public virtual SecurityQuestionMaster SecurityQuestionMaster { get; set; }
        public virtual UserCredential UserCredential { get; set; }
    }
}
