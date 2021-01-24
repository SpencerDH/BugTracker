using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Models
{
    public class AppRole : IdentityRole<int>
    {
        // Navigation properties
        // public IList<UserRole> UserRoles { get; set; }
    }
}
