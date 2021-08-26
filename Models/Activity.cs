using System;

namespace Iaf.API.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string SerialNo { get; set; }        
        public string Module { get; set; }
        public string Action { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}