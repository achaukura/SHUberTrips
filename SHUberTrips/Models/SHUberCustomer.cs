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

    public partial class SHUberCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHUberCustomer()
        {
            this.SHUberJourneys = new HashSet<SHUberJourney>();
        }

        public int SHUberCustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string EmailAddress { get; set; }
        public string BankAccountName { get; set; }
        public Nullable<int> SortCode { get; set; }
        public Nullable<int> AccountNumber { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string ErrorMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHUberJourney> SHUberJourneys { get; set; }
    }
}
