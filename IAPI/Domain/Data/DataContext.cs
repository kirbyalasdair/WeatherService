using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IAPI.Domain.Models;

namespace IAPI.Domain.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Crag> Crags { get; set; }
        public DbSet<MetArea> MetAreas { get; set; }

        public DataContext (DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Crag>().ToTable("Crags");
            builder.Entity<Crag>().HasKey(p => p.Id);
            builder.Entity<Crag>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Crag>().Property(p => p.Name).IsRequired();
            builder.Entity<Crag>().Property(p => p.Directions).IsRequired();
            builder.Entity<Crag>().Property(p => p.RockType).IsRequired();
            builder.Entity<Crag>().Property(p => p.DryFor).IsRequired();
            builder.Entity<Crag>().Property(p => p.Rating).IsRequired();

            builder.Entity<MetArea>().ToTable("MetArea");
            builder.Entity<MetArea>().HasKey(p => p.Id);
            builder.Entity<MetArea>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<MetArea>().Property(p => p.Name).IsRequired();
            builder.Entity<MetArea>().Property(p => p.Crags).IsRequired();

        }
    }
}
