using System;
using System.Collections.Generic;

namespace Iaf.API.DTO
{
    public class TicketSearchDTO
    {
        public int Id { get; set; }
        public string SerialNo  { get; set; }    
        public string IafType { get; set; }
        public string CreatedBy { get; set; }                   
        public DateTime CreatedOn { get; set; }          
        public string Status { get; set; }   
        public bool Deleted { get; set; }             
        public ICollection<TicketDetailDTO> TicketDetailDTO { get; set; }  
        public ICollection<AttachmentDTO> AttachmentDTO { get; set; }
        public ICollection<TicketApprovalDTO> TicketApprovalDTO { get; set; }
        public int Sequence { get; set; }
        public string RoutingType { get; set; }
        public string UpdatedBy { get; set; }                   
        public DateTime UpdatedOn { get; set; }         
    }
}