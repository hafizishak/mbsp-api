using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class IdmInventoryDTO
    {
        public string BusinessUnit { get; set; }
        public string ItemCode { get; set; }
        public string ItemPartNo { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }      
        public int MachineRunning { get; set; }
        public string Reorder { get; set; }
        public int QuantityIn { get; set; }
        public int QuantityOut { get; set; }    
    }
}