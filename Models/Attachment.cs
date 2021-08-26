using System;

namespace Iaf.API.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }

        public Ticket Ticket { get; set; }        
        public int TicketId { get; set; }
    }
}