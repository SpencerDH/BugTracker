using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class IssueAndUserListsViewModel
    {
        public string projectName { get; set; }
        public int projectID { get; set; }
        public ProjectTask projectTask { get; set; }
        public PaginatedList<Issue> issuesList { get; set; }
        public PaginatedList<AppUser> usersList { get; set; }
    }
}
