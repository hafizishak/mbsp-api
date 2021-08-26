using System;

namespace Iaf.API.Models.VCB
{
    public class VCBIdmItem
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; } 
    }
}