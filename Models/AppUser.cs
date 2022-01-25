using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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
        public ICollection<AppUserViewedIssue> RecentlyViewedIssues { get; set; }

        public void AddRecentlyViewedIssue(Issue issue)
        {
            if (this.RecentlyViewedIssues.Count == 20)
            {
                var issueToRemove = this.RecentlyViewedIssues.OrderByDescending(i => i.TimeViewed).Last();
                this.RecentlyViewedIssues.Remove(issueToRemove);
            }

            AppUserViewedIssue recentIssue = new AppUserViewedIssue
            {
                Issue = issue
            };

            this.RecentlyViewedIssues.Add(recentIssue);
        }
    }
}