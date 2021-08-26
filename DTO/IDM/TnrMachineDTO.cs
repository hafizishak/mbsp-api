using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class TnrMachineDTO
    {
        public string MachineCode { get; set; }    
        public string DieClassCode { get; set; }    
    }
}