using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class MasterCarrierTapeDieClassDTO
    {
        public int Id { get; set; }
        public string BusinessUnit { get; set; }
        public string DieClassCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemPartNo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }        
    }
}