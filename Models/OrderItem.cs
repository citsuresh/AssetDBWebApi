//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetDBWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public string Type { get; set; }
        public string MakeOrPublisher { get; set; }
        public string ModelOrTitle { get; set; }
        public string Version { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Value { get; set; }
        public string Status { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
