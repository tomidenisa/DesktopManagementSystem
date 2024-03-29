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
    
    public partial class Angajat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Angajat()
        {
            this.programares = new HashSet<programare>();
        }
    
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public System.DateTime DataNasterii { get; set; }
        public string Adresa { get; set; }
        public string CNP { get; set; }
        public System.DateTime DataAngajarii { get; set; }
        public Nullable<System.DateTime> DataIncheiereContract { get; set; }
        public int IdPunctDeLucru { get; set; }
        public int Id_Pozitie_Angajat { get; set; }
        public string Parola { get; set; }
        public bool Status { get; set; }
    
        public virtual pozitie_angajat pozitie_angajat { get; set; }
        public virtual Punct_Lucru_Service Punct_Lucru_Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<programare> programares { get; set; }
    }
}
