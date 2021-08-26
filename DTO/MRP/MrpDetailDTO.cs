using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iaf.API.DTO.MRP
{
    public class MrpDetailDTO
    {
        public int Id { get; set; }
        public MrpInfoDTO MrpInfoDTO { get; set; }    
        public int MrpInfoId { get; set; }    
        public string Matl { get; set; }
        public string Supplier { get; set; }
        public string VendorCode { get; set; }
        public string CPN { get; set; }
        public string Description  { get; set; }
        public int Stock { get; set; }
        public int OpenPO { get; set; }
        public int TotalDemand { get; set; }
        public int Planned { get; set; }
        public int LeadTime { get; set; }
        public int SafetyLevel { get; set; }
        public int CustomerAdditionalBufferRequest { get; set; }
        public int SpqAndMoq { get; set; }
        public string Currency { get; set; }
        public float UnitCost { get; set; }
        public float Amount { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByDesc { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }        
        public bool Deleted { get; set; }          
    }
}