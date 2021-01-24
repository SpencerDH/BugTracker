using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Data;
using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BugTracker.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Initialize password hasher object for seeding new users with passwords
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

            // Seed new projects
            modelBuilder.Entity<Project>().HasData(
                new Project { ID = 1, Name = "Moving to Atlanta" },
                new Project { ID = 2, Name = "Starting front-end studies" },
                new Project { ID = 3, Name = "Algorithm practice" }
                );

            // Ridiculously convoluted block of code for creating new users and then
            // adding their hashed passwords. There's got to be a better way of doing
            // this.
            AppUser[] appUserArrayWithoutPasswords =
            {
                new AppUser {Id = 1, UserName = "JoshFM", FirstName = "Josh", LastName = "Maddox" },
                new AppUser {Id = 2, UserName = "LaurenGA", FirstName = "Lauren", LastName = "Ackleh"},
                new AppUser {Id = 3, UserName = "SpencerDH", FirstName = "Spencer", LastName = "Hall"}
            };

            AppUser[] appUserArrayWithPasswords = new AppUser[3];
            AppUser tempAppUser;

            for (int i = 0; i < appUserArrayWithoutPasswords.Length; i++)
            {
                var passwordHash = passwordHasher.HashPassword(appUserArrayWithoutPasswords[i], "HelloGoodMorningJoeBiden123#$");

                if (i == 0)
                {
                    tempAppUser = new AppUser { Id = 1, UserName = "JoshFM", FirstName = "Josh", LastName = "Maddox", PasswordHash = passwordHash };
                    appUserArrayWithPasswords[i] = tempAppUser;
                }
                else if (i == 1)
                {
                    tempAppUser = new AppUser { Id = 2, UserName = "LaurenGA", FirstName = "Lauren", LastName = "Ackleh", PasswordHash = passwordHash };
                    appUserArrayWithPasswords[i] = tempAppUser;
                }   
                else if (i == 2)
                {
                    tempAppUser = new AppUser { Id = 3, UserName = "SpencerDH", FirstName = "Spencer", LastName = "Hall", PasswordHash = passwordHash };
                    appUserArrayWithPasswords[i] = tempAppUser;
                }
            }

            modelBuilder.Entity<AppUser>().HasData(appUserArrayWithPasswords);

            // Seed role data
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole { Id = 4, Name = "Administrator" },
                new AppRole { Id = 5, Name = "StandardUser" }
                );

            // Seed UserRoles data to make the user with Id = 3 an administrator
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { UserId = 3, RoleId = 4 }
                );

        }
    }
}
