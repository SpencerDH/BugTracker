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
        public ICollection<ProjectTask> ProjectTasks { get; set; }
        public ICollection<UserIssue> UserIssues { get; set; }
        public ICollection<IssueComment> IssueComments { get; set; }
    }
}