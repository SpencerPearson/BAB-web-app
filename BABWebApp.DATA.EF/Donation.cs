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
    
    public partial class Donation
    {
        public int DonationId { get; set; }
        public string DonorName { get; set; }
        public System.DateTime DateRecieved { get; set; }
        public int Amount { get; set; }
        public int CurrencyId { get; set; }
        public string UserId { get; set; }
        public bool IsAnon { get; set; }
        public string DonationNote { get; set; }
        public int EpisodeId { get; set; }
        public string CreditTo { get; set; }
    
        public virtual Episode Episode { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        public virtual Currency Currency { get; set; }
    }
}
