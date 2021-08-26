using System.ComponentModel.DataAnnotations;
using System;

namespace Iaf.API.Models
{
    public class Signature
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Sign { get; set; }
        public string Type { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }                      
    }
}