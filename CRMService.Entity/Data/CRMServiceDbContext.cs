using CRMService.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMService.Entity.Entity.Contact;

namespace CRMService.Entity.Data
{
    public class CRMServiceDbContext : DbContext
    {
        public CRMServiceDbContext(DbContextOptions<CRMServiceDbContext> options) : base(options)
        {

        }
        public DbSet<ContactInfo> Contact { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactInfo>().ToTable("Contact");
        }
    }
}
