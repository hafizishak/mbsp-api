using System.ComponentModel.DataAnnotations;
using System;
namespace Iaf.API.Models
{
    public class TicketDetail
    {
        public int Id { get; set; }
        public Ticket Ticket { get; set; }    
        public int TicketId { get; set; }    
        public string SerialNo  { get; set; }
        public string PartNo { get; set; }
        public string PartDesc { get; set; }
        public string LotNo { get; set; }
        public float ActualQty { get; set; }
        public float AdjustQty  { get; set; }
        public string LotProcessCode { get; set; }
        public float UnitCost { get; set; }
        public float Amount { get; set; }
        public string Reason { get; set; }
        public float Delta { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }          
    }
}