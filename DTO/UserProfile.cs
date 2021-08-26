using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Iaf.API.Models;

namespace Iaf.API.DTO
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address  { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }   
    }
}