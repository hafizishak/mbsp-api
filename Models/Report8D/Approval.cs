using System;

namespace Iaf.API.Models.Report8D
{
    public class Approval
    {
        public int Id { get; set; }
        public string Approver { get; set; }
        public bool Status { get; set; }
        public string CreatedBy  { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }
    }
}