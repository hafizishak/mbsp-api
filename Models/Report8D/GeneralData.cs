using System;

namespace Iaf.API.Models.Report8D
{
    public class GeneralData
    {
        public int Id { get; set; }
        public int CustomerPrtNo { get; set; }
        public string CustomerName { get; set; }
        public string CMSite { get; set; }
        public string CmName { get; set; }
        public string ProductName { get; set; }
        public string LotNo { get; set; }
        public string Defect { get; set; }
        public string ManufacturingDateCode { get; set; }
        public string RejectInspectedLotQuantity { get; set; }
        public string ProblemDetectedArea { get; set; }
        public DateTime BroadcomNotificationDate { get; set; }
        public int NoOfSampleReturned { get; set; }
        public DateTime SampleReceivedDate { get; set; }
        public DateTime PrtResponseDate { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }          
    }
}