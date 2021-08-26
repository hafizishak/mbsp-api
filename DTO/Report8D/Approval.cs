using System;

namespace Iaf.API.DTO.Report8D
{
    public class ApprovalDTO
    {
        public int Id { get; set; }
        public string Approver { get; set; }
        public bool Status { get; set; }
        public string CreatedBy  { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public ReportDTO ReportDTO { get; set; }
        public int ReportId { get; set; }
    }
}