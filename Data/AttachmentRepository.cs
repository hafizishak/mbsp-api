using System;
using System.Threading.Tasks;
using Iaf.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Collections.Generic;
namespace Iaf.API.Data
{
    public class AttachmentRepository : IAttachmentRepository
    {
        private readonly DataContext _dataContext;
        public AttachmentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public async Task<Attachment> Create(Attachment attachment)
        {
            await _dataContext.Attachment.AddAsync(attachment);
            await _dataContext.SaveChangesAsync();

            return attachment;
        }

        public Task<List<Attachment>> GetAllAttachment()
        {
            throw new NotImplementedException();
        }

        public Task<List<Attachment>> GetAllAttachmentByTicketId(int TicketId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Attachment>> GetAllAttachmentCustom()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Attachment>> GetAttachment(int Id)
        {
            return await _dataContext.Attachment
                            .FromSqlRaw("SELECT * FROM Attachment WHERE TicketId = '" + Id +"'").ToListAsync();
        }

        public Task<Attachment> Update(Attachment attachment)
        {
            throw new NotImplementedException();
        }
    }
}