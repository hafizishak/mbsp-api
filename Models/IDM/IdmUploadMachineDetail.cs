using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models.IDM
{
    public class IdmUploadMachineDetail
    {
        public int Id { get; set; }
        public string BilNo { get; set; }
        public string Module { get; set; }
        public string MachineCode { get; set; }
        public string DieClassCode { get; set; }
        public string MachineConvert { get; set; }
        public string Remark { get; set; }
        public string MachineStatus { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public IdmUploadMachine IdmUploadMachine { get; set; }
        public int IdmUploadMachineId { get; set; }                 
    }
}