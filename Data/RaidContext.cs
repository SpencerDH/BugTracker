﻿using System;
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

        public DbSet<BugPage> BugPages { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }

        // Seeding data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}