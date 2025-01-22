using AuthService.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Entity.Data
{
    public class AuthServiceDbContext : DbContext
    {
        public AuthServiceDbContext(DbContextOptions<AuthServiceDbContext> options) : base(options)
        {

        }

        public DbSet<Chat> Chats { get; set; }
       
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>(entity => { entity.ToTable(name: "Chat"); });
            modelBuilder.Entity<User>(entity => { entity.ToTable(name: "User"); });
        }
    }
}
