//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kindergarten_Mangement_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guadian
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guadian()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int guadian_id { get; set; }
        public string guadian_name { get; set; }
        public int gender_id { get; set; }
        public int age { get; set; }
        public byte[] personal_card { get; set; }
        public string phone { get; set; }
        public string guadian_address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
