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
    
    public partial class BuilderProjExternalAmenities
    {
        public decimal BuilderProjExternalAmenitiesId { get; set; }
        public Nullable<decimal> BuilderProjectId { get; set; }
        public Nullable<decimal> BuilidingId { get; set; }
        public Nullable<decimal> mCategoryOfExternalAmenities { get; set; }
        public string AmenitiesName { get; set; }
        public string ImageIcon { get; set; }
        public string AmenitiesDescription { get; set; }
        public string AmenitiesDistanceInKM { get; set; }
        public Nullable<System.TimeSpan> AmenitiesTimeFromBuilding { get; set; }
        public string GoogleMap { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual mBuilderProjects mBuilderProjects { get; set; }
        public virtual mCategoryOfExternalAmenities mCategoryOfExternalAmenities1 { get; set; }
    }
}
