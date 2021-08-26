using System.ComponentModel.DataAnnotations;
using System;

namespace Iaf.API.DTO
{
    public class TicketApprovalDTO
    {
        public int Id { get; set; }        
        public TicketDTO TicketDTO { get; set; }    
        public int TicketId { get; set; } 
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