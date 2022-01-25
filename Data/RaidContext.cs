using System;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Data
{
    public class RaidContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public RaidContext(DbContextOptions<RaidContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<UserIssue> UserIssues { get; set; }
        public DbSet<IssueComment> IssueComments { get; set; }
        public DbSet<AppUserViewedIssue> AppUserViewedIssues { get; set; }

        // Seeding data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<AppUser>().ToTable("AppUsers");
            modelBuilder.Entity<Project>().ToTable("Projects");
            modelBuilder.Entity<AppRole>().ToTable("AppRoles");
            modelBuilder.Entity<ProjectTask>().ToTable("ProjectTasks");
            modelBuilder.Entity<Issue>().ToTable("Issues");

            modelBuilder.Entity<UserIssue>()
                .HasKey(ui => new { ui.AppUserID, ui.IssueID });
            */

            modelBuilder.Entity<UserIssue>()
                .HasKey(ui => new { ui.AppUserID, ui.IssueID });

            /*
            modelBuilder.Entity<UserIssue>()
                .HasOne(ui => ui.AppUser)
                .WithMany(u => u.UserIssues)
                .HasForeignKey(ui => ui.AppUserID);

            modelBuilder.Entity<UserIssue>()
                .HasOne(ui => ui.Issue)
                .WithMany(i => i.UserIssues)
                .HasForeignKey(ui => ui.IssueID);
            */

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}