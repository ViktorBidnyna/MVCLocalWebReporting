//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calendar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Works
    {
        public int WorkId { get; set; }
        public string WorkName { get; set; }
        public string Description { get; set; }
        public System.DateTime BeginDate { get; set; }
        public int ReportedHours { get; set; }
        public int TasksTaskId { get; set; }
    
        public virtual Tasks Task { get; set; }
    }
}
