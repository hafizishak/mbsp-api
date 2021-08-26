using System;

namespace Iaf.API.DTO
{
    public class UserDepartmentDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentDesc { get; set; }
        public string Role { get; set; }
        public string Section { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }             
    }
}