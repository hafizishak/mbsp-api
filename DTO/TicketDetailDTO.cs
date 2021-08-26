using System.ComponentModel.DataAnnotations;
using System;
namespace Iaf.API.DTO
{
    public class TicketDetailDTO
    {
        public int Id { get; set; } 
        public TicketDTO TicketDTO { get; set; } 
        public int TicketId { get; set; }  
        public string SerialNo  { get; set; }        
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Part No Required") ]           
        public string PartNo { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Part Desc Required") ]           
        public string PartDesc { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Lot No Required") ]   
        public string LotNo { get; set; }
        public float ActualQty { get; set; }
        public float AdjustQty  { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Lot Process Code Required") ]           
        public string LotProcessCode { get; set; }
        public float UnitCost { get; set; }
        public float Amount { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Reason Required") ]           
        public string Reason { get; set; }
        public float Delta { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "CreatedBy Required") ]                 
        public string CreatedBy { get; set; }    
        public string CreatedByDesc { get; set; }         
        public DateTime CreatedOn { get; set; }          
        public bool Deleted { get; set; }           
    }
}