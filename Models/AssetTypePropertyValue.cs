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
    
    public partial class AssetTypePropertyValue
    {
        public int AssetTypePropertyValueID { get; set; }
        public int Asset { get; set; }
        public int AssetTypeProperty { get; set; }
        public string AssetTypePropertyValue1 { get; set; }
    
        public virtual Asset Asset1 { get; set; }
        public virtual AssetTypeProperty AssetTypeProperty1 { get; set; }
    }
}
