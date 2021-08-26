using System.ComponentModel.DataAnnotations;
using System;
using System.Data;
using System.Collections.Generic;
using Iaf.API.Models;

namespace Iaf.API.DTO
{
    public class TicketRoutingDTO
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