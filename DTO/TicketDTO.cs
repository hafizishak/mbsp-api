using System.ComponentModel.DataAnnotations;
using System;
using System.Data;
using System.Collections.Generic;
using Iaf.API.Models;

namespace Iaf.API.DTO
{
    public class TicketDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "4 to 8") ]
        public string SerialNo  { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "IAF Type Required") ]        
        public string IafType { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Part No Required") ]   
        public string CreatedBy { get; set; }                 
        public string CreatedByDesc { get; set; }  
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
        public bool EmailStatus { get; set; }
        public bool AssignIT { get; set; }
    }
}