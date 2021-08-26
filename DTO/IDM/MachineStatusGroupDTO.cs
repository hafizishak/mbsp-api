using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class MachineStatusGroupDTO
    {
        public string MachineCode { get; set; }
        public string MachineStatus { get; set; }
        public int TotalMC { get; set; }       
    }
}