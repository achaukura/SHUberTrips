//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SHUberTrips.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SHUberDriversSpace
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHUberDriversSpace()
        {
            this.SHUberJourneys = new HashSet<SHUberJourney>();
        }
    
        public int SHUberDriversID { get; set; }
        public string DriverFirstname { get; set; }
        public string DriverLastname { get; set; }
        public string DriverRegNumber { get; set; }
        public string DriverPassword { get; set; }
        public string DriverEmailAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHUberJourney> SHUberJourneys { get; set; }
    }
}
