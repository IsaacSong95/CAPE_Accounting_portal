//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAPE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Donation
    {
        public int ID { get; set; }

        [DisplayName("Date")]
        public System.DateTime date { get; set; }
        public Nullable<int> DID { get; set; }

        [DisplayName("Amount")]
        public decimal amount { get; set; }
        public Nullable<int> purpose { get; set; }
        public string specifics { get; set; }
        public string type { get; set; }
    }
}
