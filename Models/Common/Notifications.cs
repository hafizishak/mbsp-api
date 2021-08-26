using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models.Common
{
    [Table("Notifications")]
    public class Notifications
    {
        public int Id { get; set; }
        public string NotificationType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserCode { get; set; }
        public bool Flag { get; set; }
        public string GroupCode { get; set; }
        public string DepartmentCode { get; set; }        
        public string Url { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } 
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }        
    }
}