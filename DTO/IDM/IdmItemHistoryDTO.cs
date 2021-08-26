using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class IdmItemHistoryDTO
    {
        public int Id { get; set; }
        public string LotNo { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }  
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }  
        public IdmItemDTO IdmItem { get; set; }
        public int IdmItemId { get; set; }                
    }
}