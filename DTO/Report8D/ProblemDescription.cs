using System;

namespace Iaf.API.DTO.Report8D
{
    public class ProblemDescriptionDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string ProblemStatement { get; set; }
        public string FAResults { get; set; }
        public string FailureDetailed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public ReportDTO ReportDTO { get; set; }
        public int ReportId { get; set; }
    }
}