using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string SerialNo  { get; set; }
        public string IafType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }   
        public bool Deleted { get; set; }
        public ICollection<TicketDetail> TicketDetail { get; set; }
        public ICollection<Attachment> Attachments  { get; set; }
        public ICollection<TicketApproval> TicketApproval { get; set; }
        public int Sequence { get; set; }
        public string RoutingType { get; set; }
        public string UpdatedBy { get; set; }                   
        public DateTime UpdatedOn { get; set; }         
        public bool EmailStatus { get; set; }
        public bool AssignIT { get; set; }
    }
}