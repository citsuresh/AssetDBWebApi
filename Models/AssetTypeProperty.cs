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
    
    public partial class AssetTypeProperty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssetTypeProperty()
        {
            this.AssetTypePropertyValues = new HashSet<AssetTypePropertyValue>();
        }
    
        public int AssetTypePropertyID { get; set; }
        public int AssetType { get; set; }
        public string AssetTypeProperty1 { get; set; }
    
        public virtual AssetType AssetType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetTypePropertyValue> AssetTypePropertyValues { get; set; }
    }
}
