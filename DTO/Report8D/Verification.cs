using System;
using System.Collections.Generic;

namespace Iaf.API.DTO.Report8D
{
    public class VerificationDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string PIC { get; set; }
        public string PICDesc { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int EmailReminder { get; set; }
        public ReportDTO ReportDTO { get; set; }
        public int ReportId { get; set; }
        public List<ItemAttachmentDTO> Attachment { get; set; }       
        public DateTime LastEmailTriggerDate { get; set; } 
        public ICollection<ActionItemPICDTO> ActionItemPIC { get; set; }         
    }
}