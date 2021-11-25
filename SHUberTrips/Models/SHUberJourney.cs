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
    
    public partial class SHUberJourney
    {
        public int SHUberId { get; set; }
        public System.Data.Entity.Spatial.DbGeography StartLocation { get; set; }
        public System.Data.Entity.Spatial.DbGeography DropOffLocation { get; set; }
        public Nullable<System.TimeSpan> JourneyTime { get; set; }
        public Nullable<decimal> JourneyCost { get; set; }
        public int SHUberCustomerID { get; set; }
        public Nullable<int> DriverID { get; set; }
    
        public virtual SHUberCustomer SHUberCustomer { get; set; }
        public virtual SHUberDriversSpace SHUberDriversSpace { get; set; }
    }
}