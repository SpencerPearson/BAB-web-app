//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BABWebApp.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClipSub
    {
        public int SubmissionId { get; set; }
        public string Clip { get; set; }
        public string ProducerId { get; set; }
        public string SourceName { get; set; }
        public string Description { get; set; }
        public System.TimeSpan Duration { get; set; }
    
        public virtual UserDetail UserDetail { get; set; }
    }
}
