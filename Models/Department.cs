using System;

namespace Iaf.API.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentDesc { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}