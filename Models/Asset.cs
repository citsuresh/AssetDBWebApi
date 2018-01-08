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
    
    public partial class Asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asset()
        {
            this.AssetRelationships = new HashSet<AssetRelationship>();
            this.AssetRelationships1 = new HashSet<AssetRelationship>();
            this.AssetSubTypePropertyValues = new HashSet<AssetSubTypePropertyValue>();
            this.AssetTypePropertyValues = new HashSet<AssetTypePropertyValue>();
        }
    
        public int AssetID { get; set; }
        public int AssetType { get; set; }
        public int AssetSubType { get; set; }
        public string Name { get; set; }
        public string ClientID { get; set; }
        public string LabID { get; set; }
        public string Status { get; set; }
        public string DeviceStatus { get; set; }
        public bool HasAlarm { get; set; }
        public string AlarmMessage { get; set; }
        public Nullable<System.DateTime> LastServiceDate { get; set; }
        public Nullable<System.DateTime> NextServiceDate { get; set; }
        public string Notes { get; set; }
    
        public virtual AssetSubType AssetSubType1 { get; set; }
        public virtual AssetType AssetType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetRelationship> AssetRelationships { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetRelationship> AssetRelationships1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetSubTypePropertyValue> AssetSubTypePropertyValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetTypePropertyValue> AssetTypePropertyValues { get; set; }
    }
}