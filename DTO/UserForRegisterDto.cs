using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Iaf.API.Models;

namespace Iaf.API.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        public string EmployeeName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "4 to 8 password length") ]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        [Required]
        public string UserCode { get; set; }
        [Required]
        public string UserGroup { get; set; }

        public string JobTitle { get; set; }           
        public ICollection<UserDepartment> UserDepartment { get; set; }    
    }
}