using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.Data
{
    public class DbInitializer
    {
        public static void Initialize(RaidContext context)
        {
            // Create database if it doesn't already exist
            context.Database.EnsureCreated();

            // Check to see if the database has already been
            // seeded; if it has, no need to proceed with the
            // seeding in this method.

            /*
            // Initialize bug pages
            var bugPages = new BugPage[]
            {
                new BugPage{ID = 1, Name = "MVC issues", Description = "Add MVC methods to active recall document", Priority = 3, Status = "Open"},
                new BugPage{ID = 2, Name = "Algorithms practice", Description = "Create schedule for practicing with LeetCode", Priority = 5, Status = "Open"},
                new BugPage{ID = 3, Name = "Order pull-up station", Description = "Need to order pull-up station as soon as next paycheck comes in", Priority = 2, Status = "Open"},
                new BugPage{ID = 4, Name = "Begin bug tracker", Description = "Start writing bug tracker in C#", Priority = 5, Status = "In progress"}
            };

            foreach (BugPage bp in bugPages)
            {
                context.Add(bp);
            }

            context.SaveChanges();

            // Initialize users
            var users = new AppUser[]
            {
                new AppUser{FirstName = "Spencer", LastName = "Hall"},
                new AppUser{FirstName = "Mimi", LastName = "Ackleh"},
                new AppUser{FirstName = "Emily", LastName = "Dardaman"},
                new AppUser{FirstName = "Eric", LastName = "Daniel"},
                new AppUser{FirstName = "Josh", LastName = "Maddox"},
                new AppUser{FirstName = "Lauren", LastName = "Ackleh"}
            };

            foreach (AppUser user in users)
            {
                context.Add(user);
            }

            context.SaveChanges();
            */

            // Initialize projects
            var projects = new Project[]
            {
                new Project{ID = 1, Name = "Learning C#, .NET, and MVC"},
                new Project{ID = 2, Name = "Moving to Atlanta"}
            };

            foreach (Project project in projects)
            {
                context.Add(project);
            }

            context.SaveChanges();
        }
    }
}
