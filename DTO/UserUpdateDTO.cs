using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Iaf.API.Models;

namespace Iaf.API.DTO
{
    public class UserUpdateDto
    {
        [Required]
        public string Username { get; set; }
        public string EmployeeName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        [Required]
        public string UserCode { get; set; }
        [Required]
        public string UserGroup { get; set; }
        public ICollection<UserDepartment> UserDepartment { get; set; }    
    }
}