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
    
    public partial class usp_GetAssets_Result
    {
        public int AssetID { get; set; }
        public string AssetType { get; set; }
        public string AssetSubType { get; set; }
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
    }
}
