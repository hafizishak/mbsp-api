using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models.IDM
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public string Remarks { get; set; }
        public string Activity { get; set; }
        public string Plant { get; set; }
        public string Floor { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }   
        public OrderDetail OrderDetail { get; set; }
        public int OrderDetailId { get; set; }         
    }
}