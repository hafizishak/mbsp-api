using System;

namespace Iaf.API.Models.MRP
{
    public class MrpAttachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }

        public MrpInfo MrpInfo { get; set; }        
        public int MrpInfoId { get; set; }
    }
}