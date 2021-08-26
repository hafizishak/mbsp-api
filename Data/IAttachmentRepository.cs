using System.Threading.Tasks;
using Iaf.API.DTO;
using Iaf.API.Models;
using System.Collections.Generic;
namespace Iaf.API.Data
{
    public interface IAttachmentRepository
    {
        Task<Attachment> Create(Attachment attachment);
        Task<Attachment> Update(Attachment attachment);
        Task<List<Attachment>> GetAttachment(int Id);
        Task<List<Attachment>> GetAllAttachment();
        Task<List<Attachment>> GetAllAttachmentCustom();
        Task<List<Attachment>> GetAllAttachmentByTicketId(int TicketId);         
    }
}