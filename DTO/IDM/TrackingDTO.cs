using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class TrackingDTO
    {
        public int OrderID { get; set; }
        public string TrackingNo { get; set; }
        public string Remarks { get; set; }
        public string Activity { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByDesc { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}