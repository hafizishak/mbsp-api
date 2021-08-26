using System;

namespace Iaf.API.DTO.Report8D
{
    public class ReportAttachmentDTO
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Revision { get; set; }
        public string DocumentType { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByDesc { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public ReportDTO ReportDTO { get; set; }        
        public int ReportId { get; set; }
    }
}