//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VHaaSh.API.Modals.Database_Models
{
    using System;
    
    public partial class Usp_SelectById_Maintenance_Result
    {
        public string Machine { get; set; }
        public Nullable<bool> IsRepair { get; set; }
        public Nullable<bool> IsMaintenance { get; set; }
        public Nullable<bool> IsReplace { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string Instruction { get; set; }
        public Nullable<double> Estimate { get; set; }
        public byte[] Bill { get; set; }
    }
}
