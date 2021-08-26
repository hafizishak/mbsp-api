using System;

namespace Iaf.API.Models.Report8D
{
    public class ReportReviewer
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public bool Status { get; set; }
        public string CreatedBy  { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }        
    }
}