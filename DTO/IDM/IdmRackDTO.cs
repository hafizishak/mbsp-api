using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class IdmRackDTO
    {
        public int Id { get; set; }
        public string RackLabel { get; set; }
        public string Plant { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }   
        public ICollection<IdmRackDetailDTO> IdmRackDetailDTO { get; set; }                  
    }
}