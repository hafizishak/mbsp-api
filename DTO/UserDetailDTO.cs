using System.ComponentModel.DataAnnotations;

namespace Iaf.API.DTO
{
    public class UserDetailDTO
    {
        public string Username { get; set; }

        public string UserCode { get; set; } 
        public string Email { get; set; }
        public string Status  { get; set; }
        public string Group { get; set; }       
    }
}