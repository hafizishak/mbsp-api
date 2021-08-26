using System;
using System.Collections.Generic;

namespace Iaf.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmployeeName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set;}
        public string Status { get; set;}
        public DateTime Created { get; set; }
        public string UserCode { get; set; }
        public string UserGroup { get; set; } 
        public string JobTitle { get; set; }            
        public ICollection<UserDepartment> UserDepartment { get; set; }    
        public  ICollection<Signature> Signature { get; set; }
    }
}