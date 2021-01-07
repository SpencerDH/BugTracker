using System;
using BugTracker.Models;
using BugTracker.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class RaidContext : DbContext
    {
        public RaidContext(DbContextOptions<RaidContext> options) : base(options)
        {
        }

        public DbSet<BugPage> BugPages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBugPage> UserBugPages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectUser> ProjectUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBugPage>()
                .HasKey(ubp => new { ubp.UserID, ubp.BugPageID });

            modelBuilder.Entity<ProjectUser>()
                .HasKey(pu => new { pu.ProjectID, pu.UserID });
        }
    }
}