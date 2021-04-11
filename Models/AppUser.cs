using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class AppUser : IdentityUser<int>
    {
        // Properties
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // Navigation properties
        public ICollection<ProjectTask> ProjectTasks { get; set; }
        public ICollection<UserIssue> UserIssues { get; set; }
        public ICollection<IssueComment> IssueComments { get; set; }
    }
}