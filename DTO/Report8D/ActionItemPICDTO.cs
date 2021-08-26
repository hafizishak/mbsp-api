using System;
using System.Data;
using System.Collections.Generic;

namespace Iaf.API.DTO.Report8D
{
    public class ActionItemPICDTO
    {
        public int Id { get; set; }
        public int ActionItemId { get; set; }
        public string UserCode { get; set; }
        public string UserCodeDesc { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }       
    }
}