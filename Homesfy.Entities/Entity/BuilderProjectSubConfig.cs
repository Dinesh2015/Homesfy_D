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
    
    public partial class BuilderProjectSubConfig
    {
        public decimal ProjectSubConfigId { get; set; }
        public Nullable<decimal> ProjectConfigId { get; set; }
        public Nullable<decimal> ProjectSubConfigArea { get; set; }
        public Nullable<decimal> ProjectSubConfigPrice { get; set; }
    
        public virtual BuilderProjectConfig BuilderProjectConfig { get; set; }
    }
}
