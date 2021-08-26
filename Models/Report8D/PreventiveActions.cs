using System;
using System.Collections.Generic;

namespace Iaf.API.Models.Report8D
{
    public class PreventiveActions
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string PIC { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int EmailReminder { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }
        public DateTime LastEmailTriggerDate { get; set; }
        public ICollection<ActionItemPIC> ActionItemPIC { get; set; }         
    }
}