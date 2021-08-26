using System.Threading.Tasks;
using Iaf.API.DTO;
using Iaf.API.Models;
using System.Collections.Generic;

namespace Iaf.API.Data
{
    public interface ITicketRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;

        Task<bool> SaveAll();
        Task<IEnumerable<Ticket>> GetTickets();
        Task<Ticket> GetTicket(int Id);
        Task<Ticket> Create(Ticket ticket);
         Task<Ticket> Update(Ticket ticket);     
         Task<List<Ticket>> GetAllTicket();
    }
}