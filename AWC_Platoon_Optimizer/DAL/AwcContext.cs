using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWC_Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace AWC_Platoon_Optimizer.DAL
{
    public class AwcContext : DbContext
    {
        public AwcContext(DbContextOptions<AwcContext> options)
            : base(options)
        { }

        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guild>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Player>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Unit>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Category>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Unit_Category>()
                .HasKey(x => new { x.UnitId, x.CategoryId });
            modelBuilder.Entity<Unit_Category>()
                .HasOne(x => x.Unit)
                .WithMany(m => m.Categories)
                .HasForeignKey(x => x.UnitId);
            modelBuilder.Entity<Unit_Category>()
                .HasOne(x => x.Category)
                .WithMany(e => e.Units)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
