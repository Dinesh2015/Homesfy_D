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
    
    public partial class BuilderProjInternalAmenities
    {
        public decimal BuilderProjectInternalAmen { get; set; }
        public Nullable<decimal> BuilderProjectId { get; set; }
        public Nullable<decimal> InternalAmenitiesId { get; set; }
    
        public virtual mBuilderProjects mBuilderProjects { get; set; }
        public virtual mInternalAmenities mInternalAmenities { get; set; }
    }
}