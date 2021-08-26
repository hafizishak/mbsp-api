using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.Report8D
{
    public class ReportDTO
    {
        public int Id { get; set; }
        public string ReportNumber { get; set; }
        public string Description { get; set; }
        public string IssuedTo { get; set; }
        public string IssuedOn { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
        public string PRTNo { get; set; }
        public string Revision { get; set; }
        public string Title { get; set; }         
        public string PreparedBy { get; set; }
        public string PreparedByDesc { get; set; }
        public string ReviewedBy { get; set; }
        public string ApprovalBy { get; set; }
        public string Area { get; set; }
        public DateTime IssueDate { get; set; }  
        public DateTime RevisionDate { get; set; }
        public int EmailReminder { get; set; }         
        public DateTime LastEmailTriggerDate { get; set; }
        public ICollection<ContainmentActionsDTO> ContainmentActionsDTO { get; set; }
        public ICollection<GeneralDataDTO> GeneralDataDTO { get; set; }
        public ICollection<PreventiveActionsDTO> PreventiveActionsDTO { get; set; }
        public ICollection<ProblemDescriptionDTO> ProblemDescription { get; set; }
        public ICollection<ReoccurrencePreventionDTO> ReoccurrencePrevention { get; set; }
        public ICollection<TeamApproachDTO> TeamApproach { get; set; }
        public ICollection<VerificationDTO> Verification { get; set; }
        public ICollection<ApprovalDTO> ApprovalDTO { get; set; }
        public ICollection<ReportReviewerDTO> ReportReviewerDTO { get; set; }
    }
}