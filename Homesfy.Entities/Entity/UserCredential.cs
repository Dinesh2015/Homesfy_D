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
    
    public partial class UserCredential
    {
        public UserCredential()
        {
            this.BuyerProfile = new HashSet<BuyerProfile>();
            this.PropscoutProfile = new HashSet<PropscoutProfile>();
        }
    
        public decimal UserCredentialsID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public Nullable<decimal> MobileNumber { get; set; }
        public Nullable<decimal> AlternateNumber { get; set; }
        public Nullable<decimal> RoleId { get; set; }
        public Nullable<decimal> DepartmentID { get; set; }
        public Nullable<decimal> UserType { get; set; }
        public string FBToken { get; set; }
        public string EmailVerificationToken { get; set; }
        public string SMSVerificationToken { get; set; }
        public Nullable<decimal> NoOFAttempt { get; set; }
        public Nullable<System.DateTime> SMSVerificationDate { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ModiFiedBy { get; set; }
        public Nullable<System.DateTime> ModiFiedDate { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
    
        public virtual ICollection<BuyerProfile> BuyerProfile { get; set; }
        public virtual InDividualBasicProfile InDividualBasicProfile { get; set; }
        public virtual mCrmDepartment mCrmDepartment { get; set; }
        public virtual ICollection<PropscoutProfile> PropscoutProfile { get; set; }
        public virtual UserRoles UserRoles { get; set; }
    }
}