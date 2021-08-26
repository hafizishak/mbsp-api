using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models
{
    public class TicketRouting
    {
        public int Id { get; set; }
        public string RoutingCode { get; set; }
        public string RoutingDesc { get; set; }
        public string RoutingType { get; set; }
        public int RoutingSequence { get; set; }
        public string DepartmentCode { get; set; }
        public string RoleCode { get; set; }
        public string Section { get; set; } 
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool LastApprover { get; set; }        
    }
}