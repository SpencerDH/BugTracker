using System;
using System.Collections.Generic;

namespace BugTracker.Models
{
    public class User
    {
        // Properties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

        // Navigation properties
        public ICollection<UserBugPage> UserBugPages { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
    }
}