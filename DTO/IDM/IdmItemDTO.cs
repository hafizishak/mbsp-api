using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class IdmItemDTO
    {
        public int Id { get; set; }
        public string BusinessUnit { get; set; }
        public string ItemCode { get; set; }
        public string ItemPartNo { get; set; }
        public string ItemType { get; set; }
        public string ItemDescription { get; set; }      
        public int Quantity { get; set; }
        public int BalanceQuantity { get; set; }
        public string Unit { get; set; }
        public ICollection<IdmItemDetailDTO> IdmItemDetailDTO { get; set; }     
        public ICollection<IdmItemHistoryDTO> IdmItemHistoryDTO { get; set; }          
        public bool Deleted { get; set; }
        public DateTime ExpiredOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }        
    }
}