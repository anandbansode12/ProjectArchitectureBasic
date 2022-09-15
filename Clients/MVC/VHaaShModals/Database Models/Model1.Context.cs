﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GymMasterCS : DbContext
    {
        public GymMasterCS()
            : base("name=GymMasterCS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TblAppointment> TblAppointments { get; set; }
        public virtual DbSet<TblBatch> TblBatches { get; set; }
        public virtual DbSet<TblBloodDetail> TblBloodDetails { get; set; }
        public virtual DbSet<TblCity> TblCities { get; set; }
        public virtual DbSet<TblCorporateMembership> TblCorporateMemberships { get; set; }
        public virtual DbSet<TblCustomizedPlan> TblCustomizedPlans { get; set; }
        public virtual DbSet<TblEventDetail> TblEventDetails { get; set; }
        public virtual DbSet<TblGallery> TblGalleries { get; set; }
        public virtual DbSet<TblGender> TblGenders { get; set; }
        public virtual DbSet<TblHolidayDetail> TblHolidayDetails { get; set; }
        public virtual DbSet<TblLevel> TblLevels { get; set; }
        public virtual DbSet<TblLog> TblLogs { get; set; }
        public virtual DbSet<TblMaintenance> TblMaintenances { get; set; }
        public virtual DbSet<TblMember> TblMembers { get; set; }
        public virtual DbSet<TblMembership> TblMemberships { get; set; }
        public virtual DbSet<TblNutritionist> TblNutritionists { get; set; }
        public virtual DbSet<TblOfferDetail> TblOfferDetails { get; set; }
        public virtual DbSet<TblOwner> TblOwners { get; set; }
        public virtual DbSet<TblPaymentDetail> TblPaymentDetails { get; set; }
        public virtual DbSet<TblPaymentMode> TblPaymentModes { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblStaff> TblStaffs { get; set; }
        public virtual DbSet<TblState> TblStates { get; set; }
        public virtual DbSet<TblSupplement> TblSupplements { get; set; }
        public virtual DbSet<TblTrainer> TblTrainers { get; set; }
        public virtual DbSet<TblUserRole> TblUserRoles { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserType> TblUserTypes { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<usp_AllPaymentsDetails_Result> usp_AllPaymentsDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_AllPaymentsDetails_Result>("usp_AllPaymentsDetails");
        }
    
        public virtual int usp_Create_EventDetails(string name, Nullable<System.DateTime> date, Nullable<System.TimeSpan> time, string guest, string description)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var timeParameter = time.HasValue ?
                new ObjectParameter("Time", time) :
                new ObjectParameter("Time", typeof(System.TimeSpan));
    
            var guestParameter = guest != null ?
                new ObjectParameter("Guest", guest) :
                new ObjectParameter("Guest", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Create_EventDetails", nameParameter, dateParameter, timeParameter, guestParameter, descriptionParameter);
        }
    
        public virtual int Usp_Delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Delete", idParameter);
        }
    
        public virtual int usp_Delete_EventDetails(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Delete_EventDetails", iDParameter);
        }
    
        public virtual int Usp_Delete_Maintenance(Nullable<int> id, ObjectParameter deleteStatus, ObjectParameter result)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Delete_Maintenance", idParameter, deleteStatus, result);
        }
    
        public virtual int usp_DeleteCustomizedPlan(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteCustomizedPlan", iDParameter);
        }
    
        public virtual int usp_DeleteDetails(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteDetails", iDParameter);
        }
    
        public virtual ObjectResult<usp_GetAllCustomizedPlan_Result> usp_GetAllCustomizedPlan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllCustomizedPlan_Result>("usp_GetAllCustomizedPlan");
        }
    
        public virtual int Usp_Insert(string activity, Nullable<double> duration, string weekDay, Nullable<int> trainierId)
        {
            var activityParameter = activity != null ?
                new ObjectParameter("Activity", activity) :
                new ObjectParameter("Activity", typeof(string));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("Duration", duration) :
                new ObjectParameter("Duration", typeof(double));
    
            var weekDayParameter = weekDay != null ?
                new ObjectParameter("WeekDay", weekDay) :
                new ObjectParameter("WeekDay", typeof(string));
    
            var trainierIdParameter = trainierId.HasValue ?
                new ObjectParameter("TrainierId", trainierId) :
                new ObjectParameter("TrainierId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Insert", activityParameter, durationParameter, weekDayParameter, trainierIdParameter);
        }
    
        public virtual int Usp_Insert_Maintenance(string machine, Nullable<bool> isRepair, Nullable<bool> isMaintenance, Nullable<bool> isReplace, string instruction, Nullable<bool> isApproved, Nullable<double> estimate, byte[] bill, ObjectParameter insertStatus, ObjectParameter result)
        {
            var machineParameter = machine != null ?
                new ObjectParameter("Machine", machine) :
                new ObjectParameter("Machine", typeof(string));
    
            var isRepairParameter = isRepair.HasValue ?
                new ObjectParameter("IsRepair", isRepair) :
                new ObjectParameter("IsRepair", typeof(bool));
    
            var isMaintenanceParameter = isMaintenance.HasValue ?
                new ObjectParameter("IsMaintenance", isMaintenance) :
                new ObjectParameter("IsMaintenance", typeof(bool));
    
            var isReplaceParameter = isReplace.HasValue ?
                new ObjectParameter("IsReplace", isReplace) :
                new ObjectParameter("IsReplace", typeof(bool));
    
            var instructionParameter = instruction != null ?
                new ObjectParameter("Instruction", instruction) :
                new ObjectParameter("Instruction", typeof(string));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            var estimateParameter = estimate.HasValue ?
                new ObjectParameter("Estimate", estimate) :
                new ObjectParameter("Estimate", typeof(double));
    
            var billParameter = bill != null ?
                new ObjectParameter("Bill", bill) :
                new ObjectParameter("Bill", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Insert_Maintenance", machineParameter, isRepairParameter, isMaintenanceParameter, isReplaceParameter, instructionParameter, isApprovedParameter, estimateParameter, billParameter, insertStatus, result);
        }
    
        public virtual int usp_InsertCustomizedPlan(Nullable<int> memberId, Nullable<double> nutritionPlanCharge, byte[] customizedNutritionPlan, Nullable<double> trainingPlanCharge, byte[] customizedTrainingPlan, Nullable<int> nutritionistID, Nullable<int> trainerID, Nullable<int> supplimentId)
        {
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            var nutritionPlanChargeParameter = nutritionPlanCharge.HasValue ?
                new ObjectParameter("NutritionPlanCharge", nutritionPlanCharge) :
                new ObjectParameter("NutritionPlanCharge", typeof(double));
    
            var customizedNutritionPlanParameter = customizedNutritionPlan != null ?
                new ObjectParameter("CustomizedNutritionPlan", customizedNutritionPlan) :
                new ObjectParameter("CustomizedNutritionPlan", typeof(byte[]));
    
            var trainingPlanChargeParameter = trainingPlanCharge.HasValue ?
                new ObjectParameter("TrainingPlanCharge", trainingPlanCharge) :
                new ObjectParameter("TrainingPlanCharge", typeof(double));
    
            var customizedTrainingPlanParameter = customizedTrainingPlan != null ?
                new ObjectParameter("CustomizedTrainingPlan", customizedTrainingPlan) :
                new ObjectParameter("CustomizedTrainingPlan", typeof(byte[]));
    
            var nutritionistIDParameter = nutritionistID.HasValue ?
                new ObjectParameter("NutritionistID", nutritionistID) :
                new ObjectParameter("NutritionistID", typeof(int));
    
            var trainerIDParameter = trainerID.HasValue ?
                new ObjectParameter("TrainerID", trainerID) :
                new ObjectParameter("TrainerID", typeof(int));
    
            var supplimentIdParameter = supplimentId.HasValue ?
                new ObjectParameter("SupplimentId", supplimentId) :
                new ObjectParameter("SupplimentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertCustomizedPlan", memberIdParameter, nutritionPlanChargeParameter, customizedNutritionPlanParameter, trainingPlanChargeParameter, customizedTrainingPlanParameter, nutritionistIDParameter, trainerIDParameter, supplimentIdParameter);
        }
    
        public virtual int usp_InsertDetails(string receiverName, Nullable<int> paidAmount, Nullable<int> memberID, Nullable<int> membershipID, Nullable<int> paymentMode)
        {
            var receiverNameParameter = receiverName != null ?
                new ObjectParameter("ReceiverName", receiverName) :
                new ObjectParameter("ReceiverName", typeof(string));
    
            var paidAmountParameter = paidAmount.HasValue ?
                new ObjectParameter("PaidAmount", paidAmount) :
                new ObjectParameter("PaidAmount", typeof(int));
    
            var memberIDParameter = memberID.HasValue ?
                new ObjectParameter("MemberID", memberID) :
                new ObjectParameter("MemberID", typeof(int));
    
            var membershipIDParameter = membershipID.HasValue ?
                new ObjectParameter("MembershipID", membershipID) :
                new ObjectParameter("MembershipID", typeof(int));
    
            var paymentModeParameter = paymentMode.HasValue ?
                new ObjectParameter("PaymentMode", paymentMode) :
                new ObjectParameter("PaymentMode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertDetails", receiverNameParameter, paidAmountParameter, memberIDParameter, membershipIDParameter, paymentModeParameter);
        }
    
        public virtual ObjectResult<Usp_select_Result> Usp_select()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_select_Result>("Usp_select");
        }
    
        public virtual ObjectResult<Usp_Select_Maintenance_Result> Usp_Select_Maintenance(string machine, Nullable<bool> isRepair, Nullable<bool> isMaintenance, Nullable<bool> isReplace, string instruction, Nullable<bool> isApproved, Nullable<double> estimate)
        {
            var machineParameter = machine != null ?
                new ObjectParameter("Machine", machine) :
                new ObjectParameter("Machine", typeof(string));
    
            var isRepairParameter = isRepair.HasValue ?
                new ObjectParameter("IsRepair", isRepair) :
                new ObjectParameter("IsRepair", typeof(bool));
    
            var isMaintenanceParameter = isMaintenance.HasValue ?
                new ObjectParameter("IsMaintenance", isMaintenance) :
                new ObjectParameter("IsMaintenance", typeof(bool));
    
            var isReplaceParameter = isReplace.HasValue ?
                new ObjectParameter("IsReplace", isReplace) :
                new ObjectParameter("IsReplace", typeof(bool));
    
            var instructionParameter = instruction != null ?
                new ObjectParameter("Instruction", instruction) :
                new ObjectParameter("Instruction", typeof(string));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            var estimateParameter = estimate.HasValue ?
                new ObjectParameter("Estimate", estimate) :
                new ObjectParameter("Estimate", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_Select_Maintenance_Result>("Usp_Select_Maintenance", machineParameter, isRepairParameter, isMaintenanceParameter, isReplaceParameter, instructionParameter, isApprovedParameter, estimateParameter);
        }
    
        public virtual ObjectResult<usp_SelectAll_EventDetails_Result> usp_SelectAll_EventDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectAll_EventDetails_Result>("usp_SelectAll_EventDetails");
        }
    
        public virtual ObjectResult<usp_SelectById_EventDetails_Result> usp_SelectById_EventDetails(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectById_EventDetails_Result>("usp_SelectById_EventDetails", iDParameter);
        }
    
        public virtual ObjectResult<Usp_SelectById_Maintenance_Result> Usp_SelectById_Maintenance(Nullable<int> id, string machineName)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var machineNameParameter = machineName != null ?
                new ObjectParameter("MachineName", machineName) :
                new ObjectParameter("MachineName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_SelectById_Maintenance_Result>("Usp_SelectById_Maintenance", idParameter, machineNameParameter);
        }
    
        public virtual ObjectResult<usp_SelectDetailsById_Result> usp_SelectDetailsById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectDetailsById_Result>("usp_SelectDetailsById", idParameter);
        }
    
        public virtual int Usp_Update(Nullable<int> iD, string activity, Nullable<double> duration, string weekDay, Nullable<int> trainierId)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var activityParameter = activity != null ?
                new ObjectParameter("Activity", activity) :
                new ObjectParameter("Activity", typeof(string));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("Duration", duration) :
                new ObjectParameter("Duration", typeof(double));
    
            var weekDayParameter = weekDay != null ?
                new ObjectParameter("WeekDay", weekDay) :
                new ObjectParameter("WeekDay", typeof(string));
    
            var trainierIdParameter = trainierId.HasValue ?
                new ObjectParameter("TrainierId", trainierId) :
                new ObjectParameter("TrainierId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Update", iDParameter, activityParameter, durationParameter, weekDayParameter, trainierIdParameter);
        }
    
        public virtual int usp_Update_EventDetails(Nullable<int> iD, string name, Nullable<System.DateTime> date, Nullable<System.TimeSpan> time, string guest, string description)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var timeParameter = time.HasValue ?
                new ObjectParameter("Time", time) :
                new ObjectParameter("Time", typeof(System.TimeSpan));
    
            var guestParameter = guest != null ?
                new ObjectParameter("Guest", guest) :
                new ObjectParameter("Guest", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Update_EventDetails", iDParameter, nameParameter, dateParameter, timeParameter, guestParameter, descriptionParameter);
        }
    
        public virtual int Usp_Update_Maintenance(Nullable<int> id, string machine, Nullable<bool> isRepair, Nullable<bool> isMaintenance, Nullable<bool> isReplace, string instruction, Nullable<bool> isApproved, Nullable<double> estimate, byte[] bill, ObjectParameter updateStatus, ObjectParameter result)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var machineParameter = machine != null ?
                new ObjectParameter("Machine", machine) :
                new ObjectParameter("Machine", typeof(string));
    
            var isRepairParameter = isRepair.HasValue ?
                new ObjectParameter("IsRepair", isRepair) :
                new ObjectParameter("IsRepair", typeof(bool));
    
            var isMaintenanceParameter = isMaintenance.HasValue ?
                new ObjectParameter("IsMaintenance", isMaintenance) :
                new ObjectParameter("IsMaintenance", typeof(bool));
    
            var isReplaceParameter = isReplace.HasValue ?
                new ObjectParameter("IsReplace", isReplace) :
                new ObjectParameter("IsReplace", typeof(bool));
    
            var instructionParameter = instruction != null ?
                new ObjectParameter("Instruction", instruction) :
                new ObjectParameter("Instruction", typeof(string));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            var estimateParameter = estimate.HasValue ?
                new ObjectParameter("Estimate", estimate) :
                new ObjectParameter("Estimate", typeof(double));
    
            var billParameter = bill != null ?
                new ObjectParameter("Bill", bill) :
                new ObjectParameter("Bill", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Update_Maintenance", idParameter, machineParameter, isRepairParameter, isMaintenanceParameter, isReplaceParameter, instructionParameter, isApprovedParameter, estimateParameter, billParameter, updateStatus, result);
        }
    
        public virtual int usp_UpdateCustomizedPlan(Nullable<int> iD, Nullable<int> memberId, Nullable<double> nutritionPlanCharge, byte[] customizedNutritionPlan, Nullable<double> trainingPlanCharge, byte[] customizedTrainingPlan, Nullable<int> nutritionistID, Nullable<int> trainerID, Nullable<int> supplimentId)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            var nutritionPlanChargeParameter = nutritionPlanCharge.HasValue ?
                new ObjectParameter("NutritionPlanCharge", nutritionPlanCharge) :
                new ObjectParameter("NutritionPlanCharge", typeof(double));
    
            var customizedNutritionPlanParameter = customizedNutritionPlan != null ?
                new ObjectParameter("CustomizedNutritionPlan", customizedNutritionPlan) :
                new ObjectParameter("CustomizedNutritionPlan", typeof(byte[]));
    
            var trainingPlanChargeParameter = trainingPlanCharge.HasValue ?
                new ObjectParameter("TrainingPlanCharge", trainingPlanCharge) :
                new ObjectParameter("TrainingPlanCharge", typeof(double));
    
            var customizedTrainingPlanParameter = customizedTrainingPlan != null ?
                new ObjectParameter("CustomizedTrainingPlan", customizedTrainingPlan) :
                new ObjectParameter("CustomizedTrainingPlan", typeof(byte[]));
    
            var nutritionistIDParameter = nutritionistID.HasValue ?
                new ObjectParameter("NutritionistID", nutritionistID) :
                new ObjectParameter("NutritionistID", typeof(int));
    
            var trainerIDParameter = trainerID.HasValue ?
                new ObjectParameter("TrainerID", trainerID) :
                new ObjectParameter("TrainerID", typeof(int));
    
            var supplimentIdParameter = supplimentId.HasValue ?
                new ObjectParameter("SupplimentId", supplimentId) :
                new ObjectParameter("SupplimentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateCustomizedPlan", iDParameter, memberIdParameter, nutritionPlanChargeParameter, customizedNutritionPlanParameter, trainingPlanChargeParameter, customizedTrainingPlanParameter, nutritionistIDParameter, trainerIDParameter, supplimentIdParameter);
        }
    
        public virtual int usp_UpdateDetails(Nullable<int> iD, string receiverName, Nullable<int> paidAmount, Nullable<int> memberID, Nullable<int> membershipID, Nullable<int> paymentMode)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var receiverNameParameter = receiverName != null ?
                new ObjectParameter("ReceiverName", receiverName) :
                new ObjectParameter("ReceiverName", typeof(string));
    
            var paidAmountParameter = paidAmount.HasValue ?
                new ObjectParameter("PaidAmount", paidAmount) :
                new ObjectParameter("PaidAmount", typeof(int));
    
            var memberIDParameter = memberID.HasValue ?
                new ObjectParameter("MemberID", memberID) :
                new ObjectParameter("MemberID", typeof(int));
    
            var membershipIDParameter = membershipID.HasValue ?
                new ObjectParameter("MembershipID", membershipID) :
                new ObjectParameter("MembershipID", typeof(int));
    
            var paymentModeParameter = paymentMode.HasValue ?
                new ObjectParameter("PaymentMode", paymentMode) :
                new ObjectParameter("PaymentMode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateDetails", iDParameter, receiverNameParameter, paidAmountParameter, memberIDParameter, membershipIDParameter, paymentModeParameter);
        }
    
        public virtual ObjectResult<UspAppointmentDetails_Result> UspAppointmentDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UspAppointmentDetails_Result>("UspAppointmentDetails");
        }
    
        public virtual int UspBookAppointment(string name, string contact, string email, string appointmentSubject, string appointmentMessage, Nullable<System.DateTime> slotDate, Nullable<System.TimeSpan> slotTime, Nullable<bool> appointmentStatus, Nullable<bool> isDeleted)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("Contact", contact) :
                new ObjectParameter("Contact", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var appointmentSubjectParameter = appointmentSubject != null ?
                new ObjectParameter("AppointmentSubject", appointmentSubject) :
                new ObjectParameter("AppointmentSubject", typeof(string));
    
            var appointmentMessageParameter = appointmentMessage != null ?
                new ObjectParameter("AppointmentMessage", appointmentMessage) :
                new ObjectParameter("AppointmentMessage", typeof(string));
    
            var slotDateParameter = slotDate.HasValue ?
                new ObjectParameter("SlotDate", slotDate) :
                new ObjectParameter("SlotDate", typeof(System.DateTime));
    
            var slotTimeParameter = slotTime.HasValue ?
                new ObjectParameter("SlotTime", slotTime) :
                new ObjectParameter("SlotTime", typeof(System.TimeSpan));
    
            var appointmentStatusParameter = appointmentStatus.HasValue ?
                new ObjectParameter("AppointmentStatus", appointmentStatus) :
                new ObjectParameter("AppointmentStatus", typeof(bool));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UspBookAppointment", nameParameter, contactParameter, emailParameter, appointmentSubjectParameter, appointmentMessageParameter, slotDateParameter, slotTimeParameter, appointmentStatusParameter, isDeletedParameter);
        }
    
        public virtual int UspCheckSlotAvailability(Nullable<System.DateTime> slotDate, Nullable<System.TimeSpan> slotTime, ObjectParameter availability)
        {
            var slotDateParameter = slotDate.HasValue ?
                new ObjectParameter("SlotDate", slotDate) :
                new ObjectParameter("SlotDate", typeof(System.DateTime));
    
            var slotTimeParameter = slotTime.HasValue ?
                new ObjectParameter("SlotTime", slotTime) :
                new ObjectParameter("SlotTime", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UspCheckSlotAvailability", slotDateParameter, slotTimeParameter, availability);
        }
    
        public virtual int UspDeleteAppointment(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UspDeleteAppointment", iDParameter);
        }
    
        public virtual int UspEditAppointment(Nullable<int> iD, string name, string contact, string email, string appointmentSubject, string appointmentMessage, Nullable<System.DateTime> slotDate, Nullable<System.TimeSpan> slotTime, Nullable<bool> appointmentStatus)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("Contact", contact) :
                new ObjectParameter("Contact", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var appointmentSubjectParameter = appointmentSubject != null ?
                new ObjectParameter("AppointmentSubject", appointmentSubject) :
                new ObjectParameter("AppointmentSubject", typeof(string));
    
            var appointmentMessageParameter = appointmentMessage != null ?
                new ObjectParameter("AppointmentMessage", appointmentMessage) :
                new ObjectParameter("AppointmentMessage", typeof(string));
    
            var slotDateParameter = slotDate.HasValue ?
                new ObjectParameter("SlotDate", slotDate) :
                new ObjectParameter("SlotDate", typeof(System.DateTime));
    
            var slotTimeParameter = slotTime.HasValue ?
                new ObjectParameter("SlotTime", slotTime) :
                new ObjectParameter("SlotTime", typeof(System.TimeSpan));
    
            var appointmentStatusParameter = appointmentStatus.HasValue ?
                new ObjectParameter("AppointmentStatus", appointmentStatus) :
                new ObjectParameter("AppointmentStatus", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UspEditAppointment", iDParameter, nameParameter, contactParameter, emailParameter, appointmentSubjectParameter, appointmentMessageParameter, slotDateParameter, slotTimeParameter, appointmentStatusParameter);
        }
    }
}
