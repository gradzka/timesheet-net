//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace timesheet_net
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projects()
        {
            this.ProjectMembers = new HashSet<ProjectMembers>();
        }
    
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> Finish { get; set; }
        public int ProjectState { get; set; }
        public int SuperiorID { get; set; }
        public Nullable<int> LastEditedBy { get; set; }
        public Nullable<System.DateTime> LastEditDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationDate { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Employees Employees1 { get; set; }
        public virtual Employees Employees2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectMembers> ProjectMembers { get; set; }
        public virtual ProjectStates ProjectStates { get; set; }
    }
}
