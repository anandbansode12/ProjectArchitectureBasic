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
    
    public partial class usp_GetAllCustomizedPlan_Result
    {
        public int ID { get; set; }
        public int MemberId { get; set; }
        public double NutritionPlanCharge { get; set; }
        public byte[] CustomizedNutritionPlan { get; set; }
        public double TrainingPlanCharge { get; set; }
        public byte[] CustomizedTrainingPlan { get; set; }
        public Nullable<int> NutritionistID { get; set; }
        public Nullable<int> TrainerID { get; set; }
        public Nullable<int> SupplimentId { get; set; }
    }
}
