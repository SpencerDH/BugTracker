using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class UserAssignedIssuesViewModel
    {
        public string Username { get; set; }
        public PaginatedList<Issue> issuesList { get; set; }
    }
}
