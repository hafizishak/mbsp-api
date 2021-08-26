using System.ComponentModel.DataAnnotations;
using System;
using Iaf.API.Models;
using System.Collections.Generic;

namespace Iaf.API.DTO
{
    public class TicketApprovalViewDTO
    {

        public int Id { get; set; }          
        public int TicketId { get; set; } 
        public string UserId { get; set; }
        public string Username { get; set; }
        public List<User> User { get; set; }
        public string Role { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentDesc { get; set; }
        public string Section { get; set; }
        public string Status { get; set; }
        public bool Approved { get; set; }
        public string Remark { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }          
    }
}