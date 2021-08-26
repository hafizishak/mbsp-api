using System;
using System.Linq;
using System.Threading.Tasks;
using Iaf.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Collections.Generic;
using Iaf.API.Data.Email;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Iaf.API.DTO;
using System.Globalization;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;

namespace Iaf.API.Data
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DataContext _context;
        private readonly IEmailSender _emailSender;
        private IWebHostEnvironment _hostingEnvironment;
        public IConfiguration Configuration { get; }
        TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
        public IHttpContextAccessor _httpContextAccessor { get; }   
        public TicketRepository(DataContext context, IEmailSender emailSender, IWebHostEnvironment webHostEnvironment, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _emailSender = emailSender;
            _context = context;
            _hostingEnvironment = webHostEnvironment;
            Configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Ticket> Create(Ticket ticket)
        {

            await _context.Ticket.AddAsync(ticket);
            await _context.SaveChangesAsync();

            var tickets = await _context.Ticket.FirstOrDefaultAsync(x => x.SerialNo == ticket.SerialNo);

            return tickets;
        }

        public async Task<Ticket> GetTicket(int Id)
        {
            // var ticket = await _context.Ticket.FirstOrDefaultAsync(x => x.Id == Id);
            //var ticket = await _context.Ticket.Include(p => p.TicketDetail).FirstOrDefaultAsync(x => x.Id == Id);
            var ticket = await _context.Ticket.FirstOrDefaultAsync(x => x.Id == Id);
            //ticket.TicketDetail.Add(await _context.TicketDetail.FirstOrDefaultAsync(x => x.TicketId == Id));

            //ticket.TicketDetail.
            if (ticket == null)
                return null;

            return ticket;
        }

        public async Task<List<Ticket>> GetAllTicket()
        {
            //var ticket = await _context.Ticket.ToListAsync();
            var ticket = await _context.Ticket.FromSqlRaw("EXECUTE sp_iaf_send_email_notification;").ToListAsync();

            if (ticket == null)
                return null;

            return ticket;
        }

        public Task<Ticket> Update(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            var ticket = await _context.Ticket
                                        .Include(p => p.TicketDetail)
                                        .OrderByDescending(x => x.CreatedOn)
                                        .ToListAsync();
            //SendEmail("1");

            return ticket;
        }
    }
}