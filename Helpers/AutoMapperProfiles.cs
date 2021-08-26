using Iaf.API.Models;
using Iaf.API.Models.VCB;
using Iaf.API.Models.Common;
using Iaf.API.Models.Report8D;
using Iaf.API.Models.IDM;
using Iaf.API.Models.WSFCS;
using Iaf.API.Models.MRP;
using Iaf.API.DTO.VCB;
using Iaf.API.DTO.Common;
using Iaf.API.DTO.WSFCS;
using Iaf.API.DTO;
using Iaf.API.DTO.Report8D;
using Iaf.API.DTO.IDM;
using Iaf.API.DTO.MRP;
using AutoMapper;

namespace Iaf.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Ticket, TicketDTO>();
            CreateMap<TicketDetail, TicketDetailDTO>();
            CreateMap<AttachmentDTO, AttachmentDTO>();
            CreateMap<ContainmentActions, ContainmentActionsDTO>();
            CreateMap<PreventiveActions, PreventiveActionsDTO>();
            CreateMap<ReoccurrencePrevention, ReoccurrencePreventionDTO>();
            CreateMap<Verification, VerificationDTO>();                                    
            CreateMap<ItemAttachment, ItemAttachmentDTO>();
            CreateMap<TeamApproach, TeamApproachDTO>();
            CreateMap<ReportAttachment, ReportAttachmentDTO>();
            CreateMap<Report, ReportDTO>();
            CreateMap<ReportDTO, Report>();
            CreateMap<Activity, ActivityDTO>();
            CreateMap<ActionItemPIC, ActionItemPICDTO>();
            CreateMap<OrderDetail, OrderDetailDTO>();
            CreateMap<OrderItem, OrderItemDTO>();
            CreateMap<OrderHistory, OrderHistoryDTO>();
            CreateMap<OrderDetailDTO, OrderDetail>();
            CreateMap<OrderItemDTO, OrderItem>();
            CreateMap<OrderHistoryDTO, OrderHistory>();    
            CreateMap<IdmItem, IdmItemDTO>();  
            CreateMap<IdmItemDTO, IdmItem>();   
            CreateMap<IdmItemDetail, IdmItemDetailDTO>();  
            CreateMap<IdmItemHistory, IdmItemHistoryDTO>();  
            CreateMap<IdmUploadMachine, IdmUploadMachineDTO>();  
            CreateMap<IdmUploadMachineDTO, IdmUploadMachine>();  
            CreateMap<IdmUploadMachineDetail, IdmUploadMachineDetailDTO>();  
            CreateMap<IdmUploadMachineDetailDTO, IdmUploadMachineDetail>();              
            CreateMap<TnrCarrierGrouping, TnrCarrierGroupingDTO>();   
            CreateMap<TnrCarrierGroupingDTO, TnrCarrierGrouping>();  
            CreateMap<Notifications, NotificationsDTO>();   
            CreateMap<NotificationsDTO, Notifications>();  
            CreateMap<VCBIdmItemDTO, VCBIdmItem>(); 
            CreateMap<VCBIdmItem, VCBIdmItemDTO>();                    
            CreateMap<MrpInfo, MrpInfoDTO>();   
            // CreateMap<MrpInfoDTO, MrpInfo>();                  
            CreateMap<MrpDetail, MrpDetailDTO>(); 
            CreateMap<MrpDetailDTO, MrpDetail>();                     
            CreateMap<MrpApproval, MrpApprovalDTO>();
            CreateMap<MrpApprovalDTO, MrpApproval>();                     
            CreateMap<MrpAttachment, MrpAttachmentDTO>();
            CreateMap<MrpAttachmentDTO, MrpAttachment>();                                
        }
    }
}