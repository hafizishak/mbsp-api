using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class IdmExpiredDTO
    {
        public int IdmItemId { get; set; }
        public string ItemCode { get; set; }
        public string PartNo { get; set; }
        public string LotNo { get; set; }
        public DateTime ExpiredOn { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByDesc { get; set; }
        public DateTime CreatedOn { get; set; }      
    }
}