//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace week10.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property_Service
    {
        public int ID { get; set; }
        public int Service_ID { get; set; }
        public int Property_ID { get; set; }
    
        public virtual Property Property { get; set; }
        public virtual Service Service { get; set; }
    }
}
