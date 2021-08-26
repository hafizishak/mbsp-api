using Iaf.API.Models;
using Iaf.API.Models.Common;
using Iaf.API.Models.VCB;
using Iaf.API.Models.Report8D;
using Iaf.API.Models.Authorization;
using Iaf.API.Models.IDM;
using Iaf.API.Models.MRP;
using Iaf.API.DTO.IDM;
using Iaf.API.DTO;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
//using System.Data.Entity.Design;

namespace Iaf.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Notifications>()
            //     .HasIndex(x => new { x.UserCode, x.GroupCode });

            // modelBuilder.Entity<Notifications>()
            //     .ToTable("Notifications") ;    

            //modelBuilder.Entity<Notifications>()   
        }        

        public DbSet<Value> values { get; set; }
        public DbSet<User>  Users { get; set; }
        public DbSet<Ticket>  Ticket { get; set; }
        public DbSet<TicketDetail> TicketDetail { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        // public DbQuery<MasterCarrierTapeDieClassDTO> MasterCarrierTapeDieClassDTO { get; set; }
        // public DbQuery<TotalMachineDieClassDTO> TotalMachineDieClassDTO { get; set; }
        // public DbQuery<IdmInventoryDTO> IdmInventoryDTO { get; set; }
        // public DbQuery<MachineStatusGroupDTO> MachineStatusGroupDTO { get; set; }
        // public DbQuery<IdmRackSummaryDTO> IdmRackSummaryDTO { get; set; }
        // public DbQuery<TnrMachineDTO> TnrMachineDTO { get; set; }
        // public DbQuery<TicketSummaryDTO> TicketSummaryDTO { get; set; }
    }
}