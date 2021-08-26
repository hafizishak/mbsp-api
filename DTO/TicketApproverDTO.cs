using System.ComponentModel.DataAnnotations;
using System;

namespace Iaf.API.DTO
{
    public class TicketApproverDTO
    {
        public int Id { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionRole { get; set; }
        public string DivisionSection { get; set; }
        public string Type { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }        
    }
}