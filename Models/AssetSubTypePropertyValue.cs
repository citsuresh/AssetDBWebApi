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
    
    public partial class AssetSubTypePropertyValue
    {
        public int AssetSubTypePropertyValueID { get; set; }
        public int Asset { get; set; }
        public int AssetSubTypeProperty { get; set; }
        public string AssetSubTypePropertyValue1 { get; set; }
    
        public virtual Asset Asset1 { get; set; }
        public virtual AssetSubTypeProperty AssetSubTypeProperty1 { get; set; }
    }
}
