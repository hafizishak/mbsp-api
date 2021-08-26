using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models.MRP
{
    public class MrpApproval
    {
        public int Id { get; set; }
        public MrpInfo MrpInfo { get; set; }    
        public int MrpInfoId { get; set; }          
        public string Role { get; set; }
        public string DepartmentCode { get; set; }
        public string Section { get; set; }
        public bool Approved { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Status { get; set; }
    }
}