using System;

namespace Iaf.API.DTO.Report8D
{
    public class TeamApproachDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public ReportDTO ReportDTO { get; set; }
        public int ReportId { get; set; }
    }
}