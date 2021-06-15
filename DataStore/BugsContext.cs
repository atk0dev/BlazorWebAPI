using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataStore
{
    public class BugsContext : DbContext
    {
        public BugsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectId);

            //seeding
            modelBuilder.Entity<Project>().HasData(
                    new Project { ProjectId = 1, Name = "Project 1"}
                );

            modelBuilder.Entity<Ticket>().HasData(
                    
                new Ticket { TicketId = 1, 
                                Title = "Bug #1", 
                                ProjectId = 1, 
                                Owner = "Test User", 
                                ReportDate = DateTime.UtcNow

                },
                
                new Ticket { TicketId = 2, 
                                Title = "Bug #2", 
                                ProjectId = 1,
                                Owner = "Test User",
                    ReportDate = DateTime.UtcNow
                }
            );
        }
    }
}
