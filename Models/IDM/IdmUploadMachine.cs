using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.Models.IDM
{
    public class IdmUploadMachine
    {
        public int Id { get; set; }
        public string TrackingNo { get; set; }
        public string Shift { get; set; }
        public string UploadStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }     
        public ICollection<IdmUploadMachineDetail> IdmUploadMachineDetail { get; set; }                  
    }
}