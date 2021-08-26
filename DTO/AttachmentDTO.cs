using System.ComponentModel.DataAnnotations;
using System;
using Iaf.API.Models;

namespace Iaf.API.DTO
{
    public class AttachmentDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "File Name Required") ]         
        public string FileName { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "File Type Required") ]         
        public string FileType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public TicketDTO TicketDTO { get; set; }        
        public int TicketId { get; set; }        
    }
}