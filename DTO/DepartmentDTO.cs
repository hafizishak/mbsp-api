using System.ComponentModel.DataAnnotations;
using System;

namespace Iaf.API.DTO
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Department Code Required") ]         
        public string DepartmentCode { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Department Description Required") ]                
        public string DepartmentDesc { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }        
    }
}