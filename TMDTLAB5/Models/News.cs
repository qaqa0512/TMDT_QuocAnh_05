//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMDTLAB5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public Nullable<int> CateId { get; set; }
        public Nullable<System.DateTime> LastMod { get; set; }
        public string Frequence { get; set; }
        public Nullable<double> Priority { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
