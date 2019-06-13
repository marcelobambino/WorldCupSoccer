using WorldCupSoccer.Models;
using Microsoft.EntityFrameworkCore;
using WorldCupSoccer.Data.Configurations;

namespace WorldCupSoccer.Data 
{
    public class WorldCupSoccerContext : DbContext 
    {
        public DbSet<Event> events {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite("Data source=WorldCupSoccer.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new EventConfiguration()).Seed();
        }
    }
}