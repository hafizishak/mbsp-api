using System;

namespace Iaf.API.Models.VCB
{
    public class VCBGroup
    {
        public int Id { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}