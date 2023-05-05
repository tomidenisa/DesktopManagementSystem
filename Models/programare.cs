//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDOP2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class programare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public programare()
        {
            this.Contacts = new HashSet<Contact>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> data_inregistrare { get; set; }
        public string online_onsite { get; set; }
        public string status { get; set; }
        public Nullable<System.TimeSpan> ora_intrare { get; set; }
        public Nullable<System.TimeSpan> ora_iesire { get; set; }
        public Nullable<System.DateTime> data_programare { get; set; }
        public int angajat_id { get; set; }
        public int pozitie_angajat_id { get; set; }
        public int id_pct_lucru_service { get; set; }
    
        public virtual Angajat Angajat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual pozitie_angajat pozitie_angajat { get; set; }
        public virtual Punct_Lucru_Service Punct_Lucru_Service { get; set; }
    }
}