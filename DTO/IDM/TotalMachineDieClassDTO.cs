using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class TotalMachineDieClassDTO
    {
        public string CarrierTape { get; set; }
        public string DieClassCode { get; set; }
        public int TotalMC { get; set; }       
    }
}