//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klinik.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailPatientVisit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetailPatientVisit()
        {
            this.MsMedicines = new HashSet<MsMedicine>();
        }
    
        public int Id { get; set; }
        public string Qty { get; set; }
    
        public virtual PatientVisit PatientVisit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MsMedicine> MsMedicines { get; set; }
    }
}
