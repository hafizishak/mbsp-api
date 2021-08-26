using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class OrderDetailDTO
    {
        public int Id { get; set; }
        public string TrackingNo { get; set; }
        public string OrderBy { get; set; }
        public string MachineCode { get; set; }
        public string Plant { get; set; }
        public string Floor { get; set; }
        public string Status { get; set; }
        public int Sequence { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }   
        public ICollection<OrderItemDTO> OrderItemDTO { get; set; }
        public ICollection<OrderHistoryDTO> OrderHistoryDTO { get; set; }            

    }
}

