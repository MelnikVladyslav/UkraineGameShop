using BusinessLogic.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GameStoreDbContext : IdentityDbContext
    {
        public GameStoreDbContext()
        {

        }
        public GameStoreDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameStoreDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasOne(p => p.Ganr)
                                        .WithMany(c => c.Games)
                                        .HasForeignKey(p => p.GanrId);

            modelBuilder.SeedGames();
            modelBuilder.SeedGanrs();
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Ganr> Ganrs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
