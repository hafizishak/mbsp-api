using System;

namespace Iaf.API.DTO.Authorization
{
    public class GroupRoleDTO
    {
        public int Id { get; set; }
        public string GroupCode { get; set; }
        public string RoleCode { get; set; }        
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}