using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models.IDM
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemType { get; set; }
        public int Quantity { get; set; }
        public string MachineNo { get; set; }          
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }   
        public OrderDetail OrderDetail { get; set; }
        public int OrderDetailId { get; set; }        
    }
}