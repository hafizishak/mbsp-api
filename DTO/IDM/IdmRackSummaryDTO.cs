using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class IdmRackSummaryDTO
    {
        public int Count { get; set; }
        public string CarrierTape { get; set; }                 
    }
}