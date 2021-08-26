using System;

namespace Iaf.API.Models.Report8D
{
    public class TeamApproach
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string UserCode { get; set; }
        public string JobTitle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }
    }
}