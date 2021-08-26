using System;

namespace Iaf.API.Models
{
    public class UserDepartment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string DepartmentCode { get; set; }
        public string Role { get; set; }
        public string Section { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }        
    }
}