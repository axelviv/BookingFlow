using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaceService.Domain.Entities;
using SpaceService.Infrastructure.Persistence.Configurations;

namespace SpaceService.Infrastructure.Persistence
{
    public class SpaceDbContext : DbContext
    {
        public SpaceDbContext(DbContextOptions<SpaceDbContext> options) : base(options)
        {
        }

        public DbSet<Space> Spaces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SpaceConfiguration).Assembly);
        }
    }
}