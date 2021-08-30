//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlympicMedalListManagementSystem.Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class Athlete
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Athlete()
        {
            this.MedalLists = new HashSet<MedalList>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public System.DateTime Birthdate { get; set; }
        public int CountryID { get; set; }
        public string Portrait { get; set; }
        public byte[] PortraitImg { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedalList> MedalLists { get; set; }
    }
}