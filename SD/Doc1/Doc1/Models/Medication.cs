//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doc1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medication()
        {
            this.Medication_Plan = new HashSet<Medication_Plan>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int side_effect { get; set; }
        public Nullable<int> dosage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medication_Plan> Medication_Plan { get; set; }
        public virtual Side_Effect Side_Effect1 { get; set; }
    }
}
