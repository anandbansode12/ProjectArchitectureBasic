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
    
    public partial class TblUserType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUserType()
        {
            this.TblUserRoles = new HashSet<TblUserRole>();
        }
    
        public int UserTypeId { get; set; }
        public Nullable<System.Guid> UserTypeGuid { get; set; }
        public string UserTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblUserRole> TblUserRoles { get; set; }
    }
}