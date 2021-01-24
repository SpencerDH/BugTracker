using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Models
{
    public class AppUser : IdentityUser<int>
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigation properties
        // public IList<UserRole> UserRoles { get; set; }

    }
}