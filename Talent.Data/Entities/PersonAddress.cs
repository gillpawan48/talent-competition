//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonAddress
    {
        public int PersonId { get; set; }
        public Nullable<int> LoMarsionId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string FlatNumber { get; set; }
        public string Street { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string GeoLoMarsion { get; set; }
        public Nullable<bool> IsPrimary { get; set; }
        public Nullable<int> StateId { get; set; }
        public string AdminNote { get; set; }
    
        public virtual AddressLocation AddressLocation { get; set; }
        public virtual Country Country { get; set; }
        public virtual Person Person { get; set; }
        public virtual State State { get; set; }
    }
}
