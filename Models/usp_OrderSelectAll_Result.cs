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
    
    public partial class usp_OrderSelectAll_Result
    {
        public int ID { get; set; }
        public string OrderType { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string RequisitionNo { get; set; }
        public string Status { get; set; }
        public string Supplier { get; set; }
        public string CallReference { get; set; }
        public string CostCode { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    }
}
