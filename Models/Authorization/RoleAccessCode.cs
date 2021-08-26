using System;

namespace Iaf.API.Models.Authorization
{
    public class RoleAccessCode
    {
        public int Id { get; set; }
        public string AccessCode { get; set; }
        public string RoleCode { get; set; }        
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }        
    }
}