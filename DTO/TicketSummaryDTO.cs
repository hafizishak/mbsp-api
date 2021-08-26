using System.ComponentModel.DataAnnotations;
using System;
using System.Data;
using System.Collections.Generic;
using Iaf.API.Models;

namespace Iaf.API.DTO
{
    public class TicketSummaryDTO
    {
        public string SerialNo  { get; set; }     
        public string IafType { get; set; }
        public DateTime CreatedOn { get; set; }          
        public string PartNo { get; set; }                 
        public string LotNo { get; set; }          
        public float ActualQty { get; set; }   
        public float AdjustQty { get; set; }                   
        public float Delta { get; set; }                   
        public DateTime IT { get; set; } 
        public DateTime ShopfloorDone { get; set; } 
        public string Reason { get; set; }
    }
}