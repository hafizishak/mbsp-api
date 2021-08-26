using System;

namespace Iaf.API.Models.Report8D
{
    public class ReportAttachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Revision { get; set; }
        public string DocumentType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public Report Report { get; set; }        
        public int ReportId { get; set; }
    }
}