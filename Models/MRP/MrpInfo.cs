using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iaf.API.Models.MRP
{
    public class MrpInfo
    {
        public int Id { get; set; }
        public string SerialNo  { get; set; }
        public string MrpType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }   
        public bool Deleted { get; set; }
        public ICollection<MrpDetail> MrpDetail { get; set; }
        public ICollection<MrpAttachment> MrpAttachment  { get; set; }
        public ICollection<MrpApproval> MrpApproval { get; set; }
        public int Sequence { get; set; }
        public string RoutingType { get; set; }
        public string UpdatedBy { get; set; }                   
        public DateTime UpdatedOn { get; set; }         
    }
}