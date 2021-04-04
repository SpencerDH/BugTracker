using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class UserDetailsViewModel
    {
        public PaginatedList<Issue> Issues { get; set; }
        public PaginatedList<IssueComment> IssueComments { get; set; }
    }
}
