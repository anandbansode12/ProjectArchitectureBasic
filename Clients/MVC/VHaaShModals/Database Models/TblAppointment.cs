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
    using System.Collections.Generic;
    
    public partial class TblAppointment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string AppointmentSubject { get; set; }
        public string AppointmentMessage { get; set; }
        public System.DateTime SlotDate { get; set; }
        public System.TimeSpan SlotTime { get; set; }
        public Nullable<bool> AppointmentStatus { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
